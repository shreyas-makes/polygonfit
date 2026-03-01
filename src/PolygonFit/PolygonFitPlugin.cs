using System.Runtime.InteropServices;
using Rhino.PlugIns;

namespace PolygonFit;

[Guid("c257fffe-193d-4fae-abbb-447e2015b482")]
public class PolygonFitPlugin : PlugIn
{
    public PolygonFitPlugin()
    {
        Instance = this;
    }

    public static PolygonFitPlugin Instance { get; private set; } = null!;
}
