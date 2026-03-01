using System.Collections.Generic;
using PolygonFit.Core;
using Xunit;

namespace PolygonFit.Core.Tests;

public class PolygonMathTests
{
    [Fact]
    public void CanonicalLoopKey_IsInvariantToRotationAndReverse()
    {
        var a = new List<PlanarPoint>
        {
            new(0, 0),
            new(2, 0),
            new(2, 1),
            new(0, 1),
            new(0, 0),
        };

        var b = new List<PlanarPoint>
        {
            new(2, 1),
            new(0, 1),
            new(0, 0),
            new(2, 0),
            new(2, 1),
        };

        var c = new List<PlanarPoint>
        {
            new(0, 0),
            new(0, 1),
            new(2, 1),
            new(2, 0),
            new(0, 0),
        };

        var ka = PolygonMath.CanonicalLoopKey(a, 0.001);
        var kb = PolygonMath.CanonicalLoopKey(b, 0.001);
        var kc = PolygonMath.CanonicalLoopKey(c, 0.001);

        Assert.Equal(ka, kb);
        Assert.Equal(ka, kc);
    }

    [Fact]
    public void IsSliver_UsesSquareCentimeterThreshold()
    {
        var thresholdCm2 = 15.0;
        Assert.True(PolygonMath.IsSliverByCm2(0.0014, thresholdCm2));
        Assert.False(PolygonMath.IsSliverByCm2(0.0015, thresholdCm2));
    }

    [Fact]
    public void RemoveShortSegments_RemovesTinyEdgeAndKeepsClosedLoop()
    {
        var loop = new List<PlanarPoint>
        {
            new(0, 0),
            new(1, 0),
            new(1.0002, 0),
            new(1, 1),
            new(0, 1),
            new(0, 0),
        };

        var cleaned = PolygonMath.RemoveShortSegments(loop, 0.0005);

        Assert.True(cleaned.Count >= 5);
        Assert.Equal(cleaned[0], cleaned[^1]);
        Assert.DoesNotContain(cleaned, p => p.X == 1.0002 && p.Y == 0);
    }

    [Fact]
    public void SimplifyNearCollinear_RemovesPointNear180Degrees()
    {
        var loop = new List<PlanarPoint>
        {
            new(0, 0),
            new(1, 0),
            new(2, 0.00001),
            new(2, 1),
            new(0, 1),
            new(0, 0),
        };

        var simplified = PolygonMath.SimplifyNearCollinear(loop, 2.0);

        Assert.True(simplified.Count < loop.Count);
        Assert.Equal(simplified[0], simplified[^1]);
    }
}
