using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PolygonFit.Core;

public readonly struct PlanarPoint : IEquatable<PlanarPoint>
{
    public PlanarPoint(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }

    public double Y { get; }

    public bool Equals(PlanarPoint other)
    {
        return X.Equals(other.X) && Y.Equals(other.Y);
    }

    public override bool Equals(object? obj)
    {
        return obj is PlanarPoint other && Equals(other);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return (X.GetHashCode() * 397) ^ Y.GetHashCode();
        }
    }

    public static bool operator ==(PlanarPoint left, PlanarPoint right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(PlanarPoint left, PlanarPoint right)
    {
        return !left.Equals(right);
    }
}

public static class PolygonMath
{
    public static string CanonicalLoopKey(IReadOnlyList<PlanarPoint> closedLoop, double tolerance)
    {
        var points = NormalizeClosedLoop(closedLoop);
        if (points.Count == 0)
        {
            return string.Empty;
        }

        var quantized = points.Select(p => QuantizePoint(p, tolerance)).ToList();
        var reverse = quantized.ToList();
        reverse.Reverse();

        var forwardMin = MinimalRotation(quantized);
        var reverseMin = MinimalRotation(reverse);
        return string.CompareOrdinal(forwardMin, reverseMin) <= 0 ? forwardMin : reverseMin;
    }

    public static bool IsSliverByCm2(double areaSqMeters, double thresholdCm2)
    {
        return areaSqMeters < thresholdCm2 / 10000.0;
    }

    public static IReadOnlyList<PlanarPoint> RemoveShortSegments(IReadOnlyList<PlanarPoint> closedLoop, double minSegmentLength)
    {
        var points = NormalizeClosedLoop(closedLoop);
        if (points.Count < 3)
        {
            return closedLoop.ToList();
        }

        var changed = true;
        while (changed && points.Count >= 3)
        {
            changed = false;
            for (var i = 0; i < points.Count; i++)
            {
                var next = (i + 1) % points.Count;
                if (Distance(points[i], points[next]) < minSegmentLength)
                {
                    points.RemoveAt(next);
                    changed = true;
                    break;
                }
            }
        }

        return Close(points);
    }

    public static IReadOnlyList<PlanarPoint> SimplifyNearCollinear(IReadOnlyList<PlanarPoint> closedLoop, double angleThresholdDegrees)
    {
        var points = NormalizeClosedLoop(closedLoop);
        if (points.Count < 3)
        {
            return closedLoop.ToList();
        }

        var thresholdRadians = angleThresholdDegrees * Math.PI / 180.0;
        var changed = true;

        while (changed && points.Count >= 3)
        {
            changed = false;
            for (var i = 0; i < points.Count; i++)
            {
                var prev = (i - 1 + points.Count) % points.Count;
                var next = (i + 1) % points.Count;

                var v1x = points[prev].X - points[i].X;
                var v1y = points[prev].Y - points[i].Y;
                var v2x = points[next].X - points[i].X;
                var v2y = points[next].Y - points[i].Y;

                var len1 = Math.Sqrt((v1x * v1x) + (v1y * v1y));
                var len2 = Math.Sqrt((v2x * v2x) + (v2y * v2y));
                if (len1 <= double.Epsilon || len2 <= double.Epsilon)
                {
                    continue;
                }

                var dot = ((v1x * v2x) + (v1y * v2y)) / (len1 * len2);
                if (dot > 1.0)
                {
                    dot = 1.0;
                }
                else if (dot < -1.0)
                {
                    dot = -1.0;
                }

                var angle = Math.Acos(dot);
                if (Math.Abs(Math.PI - angle) <= thresholdRadians)
                {
                    points.RemoveAt(i);
                    changed = true;
                    break;
                }
            }
        }

        return Close(points);
    }

    private static List<PlanarPoint> NormalizeClosedLoop(IReadOnlyList<PlanarPoint> closedLoop)
    {
        var points = closedLoop.ToList();
        if (points.Count == 0)
        {
            return points;
        }

        if (points[0] == points[points.Count - 1])
        {
            points.RemoveAt(points.Count - 1);
        }

        return points;
    }

    private static IReadOnlyList<PlanarPoint> Close(List<PlanarPoint> points)
    {
        var copy = points.ToList();
        if (copy.Count > 0)
        {
            copy.Add(copy[0]);
        }

        return copy;
    }

    private static string QuantizePoint(PlanarPoint p, double tolerance)
    {
        var qx = Math.Round(p.X / tolerance, MidpointRounding.AwayFromZero);
        var qy = Math.Round(p.Y / tolerance, MidpointRounding.AwayFromZero);
        return qx.ToString(CultureInfo.InvariantCulture) + ":" + qy.ToString(CultureInfo.InvariantCulture);
    }

    private static string MinimalRotation(List<string> values)
    {
        var best = string.Join(";", values);
        for (var i = 1; i < values.Count; i++)
        {
            var rotated = values.Skip(i).Concat(values.Take(i));
            var candidate = string.Join(";", rotated);
            if (string.CompareOrdinal(candidate, best) < 0)
            {
                best = candidate;
            }
        }

        return best;
    }

    private static double Distance(PlanarPoint a, PlanarPoint b)
    {
        var dx = a.X - b.X;
        var dy = a.Y - b.Y;
        return Math.Sqrt((dx * dx) + (dy * dy));
    }
}
