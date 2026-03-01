using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using PolygonFit.Core;
using Rhino;
using Rhino.Commands;
using Rhino.DocObjects;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;

namespace PolygonFit.Commands;

public class CleanCityPolygonsCommand : Command
{
    private const double VertexSnapTolerance = 0.001;
    private const double MergeTolerance = 0.0005;
    private const double GapCloseTolerance = 0.001;
    private const double MinSegmentLength = 0.0005;
    private const double SliverAreaSqCentimeters = 15.0;
    private const double AngleSimplificationDegrees = 2.0;

    private const string PreviewLayerName = "_PolygonFit_Preview";
    private const string ReviewLayerName = "_PolygonFit_Review";

    public override string EnglishName => "CleanCityPolygons";

    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
        var layer = PromptForLayer(doc);
        if (layer == null)
        {
            return Result.Cancel;
        }

        var records = CollectLayerPolygons(doc, layer);
        if (records.Count == 0)
        {
            RhinoApp.WriteLine("No closed planar curves found on the selected layer.");
            return Result.Nothing;
        }

        ProcessPolygons(records, doc.ModelAbsoluteTolerance);

        var previewLayerIndex = EnsureLayer(doc, PreviewLayerName, Color.DeepSkyBlue);
        var reviewLayerIndex = EnsureLayer(doc, ReviewLayerName, Color.OrangeRed);
        var previewIds = CreatePreview(doc, records, previewLayerIndex);

        var apply = PromptApplyCancel();
        RemoveObjects(doc, previewIds);

        if (!apply)
        {
            doc.Views.Redraw();
            return Result.Cancel;
        }

        ApplyResults(doc, records, reviewLayerIndex);
        doc.Views.Redraw();
        return Result.Success;
    }

    private static Layer? PromptForLayer(RhinoDoc doc)
    {
        var defaultLayer = doc.Layers.CurrentLayer?.FullPath ?? string.Empty;
        var layerName = defaultLayer;
        var rc = RhinoGet.GetString("Layer to clean", true, ref layerName);
        if (rc != Result.Success)
        {
            return null;
        }

        var layer = doc.Layers.FindName(layerName);
        if (layer == null || layer.IsDeleted)
        {
            RhinoApp.WriteLine("Layer not found.");
            return null;
        }

        return layer;
    }

    private static List<PolygonRecord> CollectLayerPolygons(RhinoDoc doc, Layer layer)
    {
        var output = new List<PolygonRecord>();
        var objects = doc.Objects.FindByLayer(layer.FullPath);
        if (objects == null)
        {
            return output;
        }

        foreach (var obj in objects)
        {
            var curveObj = obj as CurveObject;
            if (curveObj == null)
            {
                continue;
            }

            var curve = curveObj.CurveGeometry;
            if (curve == null || !curve.IsClosed)
            {
                continue;
            }

            if (!curve.TryGetPlane(out var plane) || Math.Abs(plane.Normal.Z) < 0.999999)
            {
                continue;
            }

            var polyline = ToWorkingPolyline(curve, MergeTolerance);
            if (polyline == null)
            {
                continue;
            }

            output.Add(new PolygonRecord
            {
                SourceId = obj.Id,
                OriginalLayerIndex = obj.Attributes.LayerIndex,
                Working = polyline,
                OriginalAttributes = obj.Attributes.Duplicate(),
                Status = PolygonStatus.Keep,
            });
        }

        return output;
    }

    private static Polyline? ToWorkingPolyline(Curve curve, double sampleStep)
    {
        if (curve.TryGetPolyline(out var direct))
        {
            var pl = EnsureClosed(direct);
            return pl.Count >= 4 ? pl : null;
        }

        var length = curve.GetLength();
        if (!RhinoMath.IsValidDouble(length) || length <= RhinoMath.ZeroTolerance)
        {
            return null;
        }

        var divisionCount = Math.Max(24, (int)Math.Ceiling(length / Math.Max(sampleStep, 0.01)));
        var points = new List<Point3d>(divisionCount + 1);
        var domain = curve.Domain;

        for (var i = 0; i < divisionCount; i++)
        {
            var t = domain.ParameterAt(i / (double)divisionCount);
            points.Add(curve.PointAt(t));
        }

        points.Add(points[0]);
        var pline = new Polyline(points);
        pline = EnsureClosed(pline);
        return pline.Count >= 4 ? pline : null;
    }

    private static void ProcessPolygons(List<PolygonRecord> records, double docTol)
    {
        SnapVertices(records, VertexSnapTolerance);
        SnapVerticesToNearbyEdges(records, GapCloseTolerance);
        SnapVertices(records, MergeTolerance);

        foreach (var rec in records)
        {
            rec.Working = CleanupPolyline(rec.Working, MinSegmentLength, AngleSimplificationDegrees);
            if (rec.Working.Count < 4)
            {
                rec.Status = PolygonStatus.DeleteDegenerate;
            }
        }

        MarkDuplicates(records, MergeTolerance);
        MarkSlivers(records, SliverAreaSqCentimeters);
        MarkOverlaps(records, Math.Max(docTol, MergeTolerance));
        MarkHoleFlags(records, Math.Max(docTol, MergeTolerance));
    }

    private static void SnapVertices(List<PolygonRecord> records, double tolerance)
    {
        var all = new List<(PolygonRecord record, int index)>();
        foreach (var record in records)
        {
            for (var i = 0; i < record.Working.Count - 1; i++)
            {
                all.Add((record, i));
            }
        }

        var clusters = new List<Cluster>();
        foreach (var item in all)
        {
            var point = item.record.Working[item.index];
            var assigned = false;

            for (var i = 0; i < clusters.Count; i++)
            {
                if (clusters[i].Center.DistanceTo(point) <= tolerance)
                {
                    clusters[i] = clusters[i].Add(point);
                    item.record.Working[item.index] = clusters[i].Center;
                    assigned = true;
                    break;
                }
            }

            if (!assigned)
            {
                clusters.Add(new Cluster(point, 1));
            }
        }

        foreach (var record in records)
        {
            record.Working = EnsureClosed(record.Working);
        }
    }

    private static void SnapVerticesToNearbyEdges(List<PolygonRecord> records, double tolerance)
    {
        for (var i = 0; i < records.Count; i++)
        {
            var poly = records[i].Working;
            for (var v = 0; v < poly.Count - 1; v++)
            {
                var source = poly[v];
                var best = source;
                var bestDistance = tolerance;

                for (var j = 0; j < records.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    var other = records[j].Working;
                    for (var s = 0; s < other.Count - 1; s++)
                    {
                        var a = other[s];
                        var b = other[s + 1];
                        var projected = ClosestPointOnSegment(source, a, b);
                        var dist = source.DistanceTo(projected);
                        if (dist < bestDistance)
                        {
                            bestDistance = dist;
                            best = projected;
                        }
                    }
                }

                if (bestDistance <= tolerance)
                {
                    poly[v] = best;
                }
            }

            records[i].Working = EnsureClosed(poly);
        }
    }

    private static Polyline CleanupPolyline(Polyline input, double minSegmentLength, double angleThresholdDegrees)
    {
        var pts = input.ToList();
        if (pts.Count < 4)
        {
            return input;
        }

        pts.RemoveAt(pts.Count - 1);

        var changed = true;
        while (changed && pts.Count >= 3)
        {
            changed = false;

            for (var i = 0; i < pts.Count; i++)
            {
                var next = (i + 1) % pts.Count;
                if (pts[i].DistanceTo(pts[next]) < minSegmentLength)
                {
                    pts.RemoveAt(next);
                    changed = true;
                    break;
                }
            }

            if (changed || pts.Count < 3)
            {
                continue;
            }

            var angleThresholdRadians = RhinoMath.ToRadians(angleThresholdDegrees);
            for (var i = 0; i < pts.Count; i++)
            {
                var prev = (i - 1 + pts.Count) % pts.Count;
                var next = (i + 1) % pts.Count;

                var v1 = pts[prev] - pts[i];
                var v2 = pts[next] - pts[i];
                if (!v1.Unitize() || !v2.Unitize())
                {
                    continue;
                }

                var angle = Vector3d.VectorAngle(v1, v2);
                if (Math.Abs(Math.PI - angle) <= angleThresholdRadians)
                {
                    pts.RemoveAt(i);
                    changed = true;
                    break;
                }
            }
        }

        if (pts.Count < 3)
        {
            return input;
        }

        pts.Add(pts[0]);
        return new Polyline(pts);
    }

    private static void MarkDuplicates(List<PolygonRecord> records, double tolerance)
    {
        var seen = new Dictionary<string, int>(StringComparer.Ordinal);

        for (var i = 0; i < records.Count; i++)
        {
            if (IsDeleteStatus(records[i].Status))
            {
                continue;
            }

            var key = CanonicalPolylineKey(records[i].Working, tolerance);
            if (seen.ContainsKey(key))
            {
                records[i].Status = PolygonStatus.DeleteDuplicate;
            }
            else
            {
                seen[key] = i;
            }
        }
    }

    private static void MarkSlivers(List<PolygonRecord> records, double minAreaCm2)
    {
        foreach (var rec in records)
        {
            if (IsDeleteStatus(rec.Status))
            {
                continue;
            }

            var area = PolygonArea(rec.Working);
            if (PolygonMath.IsSliverByCm2(area, minAreaCm2))
            {
                rec.Status = PolygonStatus.DeleteSliver;
            }
        }
    }

    private static void MarkOverlaps(List<PolygonRecord> records, double tolerance)
    {
        for (var i = 0; i < records.Count; i++)
        {
            if (IsDeleteStatus(records[i].Status))
            {
                continue;
            }

            var curveA = new PolylineCurve(records[i].Working);
            var areaA = PolygonArea(records[i].Working);
            var bboxA = curveA.GetBoundingBox(true);

            for (var j = i + 1; j < records.Count; j++)
            {
                if (IsDeleteStatus(records[j].Status))
                {
                    continue;
                }

                var curveB = new PolylineCurve(records[j].Working);
                var bboxB = curveB.GetBoundingBox(true);
                var intersection = BoundingBox.Intersection(bboxA, bboxB);
                if (!intersection.IsValid)
                {
                    continue;
                }

                var overlaps = Curve.CreateBooleanIntersection(curveA, curveB, tolerance);
                if (overlaps == null || overlaps.Length == 0)
                {
                    continue;
                }

                var areaB = PolygonArea(records[j].Working);
                if (areaA >= areaB)
                {
                    records[j].Status = PolygonStatus.DeleteOverlap;
                }
                else
                {
                    records[i].Status = PolygonStatus.DeleteOverlap;
                    break;
                }
            }
        }
    }

    private static void MarkHoleFlags(List<PolygonRecord> records, double tolerance)
    {
        var active = records.Where(r => !IsDeleteStatus(r.Status)).ToList();

        for (var i = 0; i < active.Count; i++)
        {
            var a = active[i];
            var curveA = new PolylineCurve(a.Working);
            var amp = AreaMassProperties.Compute(curveA);
            if (amp == null)
            {
                continue;
            }

            var centroid = amp.Centroid;
            for (var j = 0; j < active.Count; j++)
            {
                if (i == j)
                {
                    continue;
                }

                var curveB = new PolylineCurve(active[j].Working);
                var containment = curveB.Contains(centroid, Plane.WorldXY, tolerance);
                if (containment == PointContainment.Inside)
                {
                    a.Status = PolygonStatus.FlagHoleOrIsland;
                    break;
                }
            }
        }
    }

    private static List<Guid> CreatePreview(RhinoDoc doc, List<PolygonRecord> records, int previewLayerIndex)
    {
        var ids = new List<Guid>();

        foreach (var rec in records)
        {
            var color = rec.Status switch
            {
                PolygonStatus.Keep => Color.LimeGreen,
                PolygonStatus.FlagHoleOrIsland => Color.Gold,
                _ => Color.Red,
            };

            var attrs = new ObjectAttributes
            {
                LayerIndex = previewLayerIndex,
                ColorSource = ObjectColorSource.ColorFromObject,
                ObjectColor = color,
            };

            var id = doc.Objects.AddCurve(new PolylineCurve(rec.Working), attrs);
            if (id != Guid.Empty)
            {
                ids.Add(id);
            }
        }

        doc.Views.Redraw();
        return ids;
    }

    private static bool PromptApplyCancel()
    {
        var go = new GetOption();
        go.SetCommandPrompt("Preview ready. Choose action");
        var applyIndex = go.AddOption("Apply");
        var cancelIndex = go.AddOption("Cancel");

        while (true)
        {
            var res = go.Get();
            if (res == GetResult.Option)
            {
                if (go.Option().Index == applyIndex)
                {
                    return true;
                }

                if (go.Option().Index == cancelIndex)
                {
                    return false;
                }
            }

            if (res == GetResult.Cancel)
            {
                return false;
            }
        }
    }

    private static void ApplyResults(RhinoDoc doc, List<PolygonRecord> records, int reviewLayerIndex)
    {
        foreach (var rec in records)
        {
            if (rec.Status == PolygonStatus.FlagHoleOrIsland)
            {
                var reviewAttrs = rec.OriginalAttributes.Duplicate();
                reviewAttrs.LayerIndex = reviewLayerIndex;
                reviewAttrs.ColorSource = ObjectColorSource.ColorFromObject;
                reviewAttrs.ObjectColor = Color.OrangeRed;
                doc.Objects.AddCurve(new PolylineCurve(rec.Working), reviewAttrs);
                continue;
            }

            if (IsDeleteStatus(rec.Status))
            {
                doc.Objects.Delete(rec.SourceId, true);
                continue;
            }

            var attrs = rec.OriginalAttributes.Duplicate();
            attrs.LayerIndex = rec.OriginalLayerIndex;

            doc.Objects.Delete(rec.SourceId, true);
            doc.Objects.AddCurve(new PolylineCurve(rec.Working), attrs);
        }
    }

    private static void RemoveObjects(RhinoDoc doc, IEnumerable<Guid> ids)
    {
        foreach (var id in ids)
        {
            doc.Objects.Delete(id, true);
        }
    }

    private static int EnsureLayer(RhinoDoc doc, string name, Color color)
    {
        var existing = doc.Layers.FindName(name);
        if (existing != null && !existing.IsDeleted)
        {
            return existing.Index;
        }

        var layer = new Layer
        {
            Name = name,
            Color = color,
        };

        return doc.Layers.Add(layer);
    }

    private static Polyline EnsureClosed(Polyline polyline)
    {
        if (polyline.Count == 0)
        {
            return polyline;
        }

        var points = polyline.ToList();
        if (points[0].DistanceTo(points[points.Count - 1]) > RhinoMath.ZeroTolerance)
        {
            points.Add(points[0]);
        }

        return new Polyline(points);
    }

    private static string CanonicalPolylineKey(Polyline polyline, double tolerance)
    {
        var loop = polyline
            .Select(p => new PlanarPoint(p.X, p.Y))
            .ToList();
        return PolygonMath.CanonicalLoopKey(loop, tolerance);
    }

    private static double PolygonArea(Polyline polyline)
    {
        var amp = AreaMassProperties.Compute(new PolylineCurve(polyline));
        return amp == null ? 0.0 : Math.Abs(amp.Area);
    }

    private static Point3d ClosestPointOnSegment(Point3d p, Point3d a, Point3d b)
    {
        var ab = b - a;
        var denom = ab * ab;
        if (denom <= RhinoMath.ZeroTolerance)
        {
            return a;
        }

        var t = ((p - a) * ab) / denom;
        t = Math.Max(0.0, Math.Min(1.0, t));
        return a + t * ab;
    }

    private static bool IsDeleteStatus(PolygonStatus status)
    {
        return status == PolygonStatus.DeleteDuplicate
            || status == PolygonStatus.DeleteSliver
            || status == PolygonStatus.DeleteOverlap
            || status == PolygonStatus.DeleteDegenerate;
    }

    private readonly struct Cluster
    {
        public Cluster(Point3d center, int count)
        {
            Center = center;
            Count = count;
        }

        public Point3d Center { get; }

        public int Count { get; }

        public Cluster Add(Point3d p)
        {
            var newCount = Count + 1;
            var center = new Point3d(
                ((Center.X * Count) + p.X) / newCount,
                ((Center.Y * Count) + p.Y) / newCount,
                ((Center.Z * Count) + p.Z) / newCount);
            return new Cluster(center, newCount);
        }
    }

    private sealed class PolygonRecord
    {
        public Guid SourceId { get; set; }

        public int OriginalLayerIndex { get; set; }

        public Polyline Working { get; set; } = default!;

        public ObjectAttributes OriginalAttributes { get; set; } = default!;

        public PolygonStatus Status { get; set; }
    }

    private enum PolygonStatus
    {
        Keep,
        DeleteDuplicate,
        DeleteSliver,
        DeleteOverlap,
        DeleteDegenerate,
        FlagHoleOrIsland,
    }
}
