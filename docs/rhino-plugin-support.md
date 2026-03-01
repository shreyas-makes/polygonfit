# Rhino Developer Samples

This repository contains comprehensive sample code for developing plugins, scripts, and applications within the Rhino and Grasshopper ecosystem. It provides working examples across multiple SDKs including RhinoCommon, rhino3dm, Rhino.Inside, Grasshopper, openNURBS, and Rhino Compute, supporting languages such as C#, Python, JavaScript, VB.NET, and C++.

The samples demonstrate how to create geometry, manipulate 3D models, build custom plugins, integrate Rhino into external applications, and leverage cloud computing for geometry operations. Each SDK targets different use cases: RhinoCommon for Rhino plugins, rhino3dm for standalone geometry libraries, Grasshopper for visual programming components, and Rhino Compute for server-side geometry processing.

---

## RhinoCommon - Add Circle

Creates a circle in the Rhino document using the RhinoCommon SDK, which is the primary .NET API for Rhino plugin development.

```csharp
// C# - Add a circle to the document
using System;

public static Rhino.Commands.Result AddCircle(Rhino.RhinoDoc doc)
{
    Rhino.Geometry.Point3d center = new Rhino.Geometry.Point3d(0, 0, 0);
    const double radius = 10.0;
    Rhino.Geometry.Circle c = new Rhino.Geometry.Circle(center, radius);

    if (doc.Objects.AddCircle(c) != Guid.Empty)
    {
        doc.Views.Redraw();
        return Rhino.Commands.Result.Success;
    }
    return Rhino.Commands.Result.Failure;
}
```

---

## RhinoCommon - Add Circle (Python)

Creates a circle using RhinoPython scripting within Rhino's Python editor.

```python
# Python - Add a circle to the document
import Rhino
import scriptcontext
import System.Guid

def AddCircle():
    center = Rhino.Geometry.Point3d(0, 0, 0)
    radius = 10.0
    c = Rhino.Geometry.Circle(center, radius)

    if scriptcontext.doc.Objects.AddCircle(c) != System.Guid.Empty:
        scriptcontext.doc.Views.Redraw()
        return Rhino.Commands.Result.Success
    return Rhino.Commands.Result.Failure

if __name__ == "__main__":
    AddCircle()
```

---

## RhinoCommon - Add Mesh

Creates a mesh with vertices and quad faces, demonstrating mesh construction and normal computation.

```csharp
// C# - Create a mesh with vertices and faces
using System;

public static Rhino.Commands.Result AddMesh(Rhino.RhinoDoc doc)
{
    Rhino.Geometry.Mesh mesh = new Rhino.Geometry.Mesh();

    // Add vertices (12 points in a 4x3 grid)
    mesh.Vertices.Add(0.0, 0.0, 1.0); // 0
    mesh.Vertices.Add(1.0, 0.0, 1.0); // 1
    mesh.Vertices.Add(2.0, 0.0, 1.0); // 2
    mesh.Vertices.Add(3.0, 0.0, 0.0); // 3
    mesh.Vertices.Add(0.0, 1.0, 1.0); // 4
    mesh.Vertices.Add(1.0, 1.0, 2.0); // 5
    mesh.Vertices.Add(2.0, 1.0, 1.0); // 6
    mesh.Vertices.Add(3.0, 1.0, 0.0); // 7
    mesh.Vertices.Add(0.0, 2.0, 1.0); // 8
    mesh.Vertices.Add(1.0, 2.0, 1.0); // 9
    mesh.Vertices.Add(2.0, 2.0, 1.0); // 10
    mesh.Vertices.Add(3.0, 2.0, 1.0); // 11

    // Add quad faces (6 faces)
    mesh.Faces.AddFace(0, 1, 5, 4);
    mesh.Faces.AddFace(1, 2, 6, 5);
    mesh.Faces.AddFace(2, 3, 7, 6);
    mesh.Faces.AddFace(4, 5, 9, 8);
    mesh.Faces.AddFace(5, 6, 10, 9);
    mesh.Faces.AddFace(6, 7, 11, 10);

    mesh.Normals.ComputeNormals();
    mesh.Compact();

    if (doc.Objects.AddMesh(mesh) != Guid.Empty)
    {
        doc.Views.Redraw();
        return Rhino.Commands.Result.Success;
    }
    return Rhino.Commands.Result.Failure;
}
```

---

## rhino3dm - Simple Arc Creation (Python)

Creates geometry using the standalone rhino3dm library, which works independently of Rhino.

```python
# Python - Create geometry with rhino3dm (standalone)
import rhino3dm

# Create a 3D point
center = rhino3dm.Point3d(1, 2, 3)

# Create an arc at the center point with radius 10 and angle 1 radian
arc = rhino3dm.Arc(center, 10, 1)

# Convert arc to NURBS curve
nc = arc.ToNurbsCurve()

# Get the start point of the curve
start = nc.PointAtStart
print(start)  # Output: Point3d(11, 2, 3)
```

---

## rhino3dm - Read 3DM File (JavaScript/Node.js)

Reads a Rhino .3dm file and extracts geometry information using the JavaScript rhino3dm library.

```javascript
// Node.js - Read a 3dm file and count object types
import * as fs from 'fs'
import rhino3dm from 'rhino3dm'

// Initialize rhino3dm (async)
const rhino = await rhino3dm()

// Read the file
const buffer = fs.readFileSync('model.3dm')
const arr = new Uint8Array(buffer)
const file3dm = rhino.File3dm.fromByteArray(arr)
const objects = file3dm.objects()

// Count geometry types
const stats = {}
for (let i = 0; i < objects.count; i++) {
    const geometry = objects.get(i).geometry()
    const prop = geometry.objectType.constructor.name.substring(11)

    if (!Object.hasOwn(stats, prop)) {
        stats[prop] = 0
    }
    stats[prop]++
}

console.log(stats)
// Output: { Brep: 5, Mesh: 2, Curve: 10, ... }
```

---

## rhino3dm - Sketch and Save 3DM (Browser JavaScript)

Interactive sketching with NURBS curves and exporting to .3dm file format in the browser.

```javascript
// Browser - Create NURBS curves and save to 3dm
import rhino3dm from 'rhino3dm'

const rhino = await rhino3dm()

// Create a new 3dm document
let doc = new rhino3dm.File3dm()

// Create points for a NURBS curve
let points = new rhino.Point3dList()
points.add(0, 0, 0)
points.add(5, 10, 0)
points.add(10, 5, 0)
points.add(15, 10, 0)

// Create a degree 3 closed periodic NURBS curve
let curve = rhino.NurbsCurve.create(true, 3, points)

// Add curve to document
doc.objects().add(curve, null)

// Export to 3dm file (Rhino 7 format)
let options = new rhino.File3dmWriteOptions()
options.version = 7
let buffer = doc.toByteArray(options)

// Download the file
let blob = new Blob([buffer], {type: "application/octet-stream"})
let link = document.createElement('a')
link.href = window.URL.createObjectURL(blob)
link.download = "sketch.3dm"
link.click()

// Cleanup
doc.delete()
```

---

## Rhino Compute - Circle Boolean Intersection (C#)

Performs server-side geometry operations using Rhino Compute for complex calculations.

```csharp
// C# - Boolean intersection of circles using Rhino Compute
using Rhino.Geometry;
using Rhino.Compute;

class Program
{
    static void Main(string[] args)
    {
        // Configure Rhino Compute server
        ComputeServer.WebAddress = "http://localhost:8081/";
        // ComputeServer.ApiKey = "your-api-key";

        // Create two circles using local rhino3dm
        var c1 = new Circle(new Point3d(0, 0, 0), 100);
        var c2 = new Circle(new Point3d(30, 30, 0), 70);

        // Call Compute server for boolean intersection
        var intersectionCurves = CurveCompute.CreateBooleanIntersection(
            c1.ToNurbsCurve(),
            c2.ToNurbsCurve()
        );

        if (intersectionCurves != null)
        {
            // Create a Brep from the intersection curves
            var brep = Brep.CreateTrimmedPlane(c1.Plane, intersectionCurves);

            // Mesh the Brep on the server
            var meshes = MeshCompute.CreateFromBrep(brep, MeshingParameters.FastRenderMesh);

            Console.WriteLine($"Created {meshes.Length} meshes");
        }
    }
}
```

---

## Rhino Compute - Grasshopper Definition Evaluation (C#)

Evaluates a Grasshopper definition on the server with custom input parameters.

```csharp
// C# - Evaluate a Grasshopper definition remotely
using System.Collections.Generic;
using System.Linq;
using Rhino.Compute;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        ComputeServer.WebAddress = "http://localhost:8081/";

        // Path to Grasshopper definition
        var definitionPath = "SpikyThing.gh";

        // Create input parameter trees
        var trees = new List<GrasshopperDataTree>();

        // Add "Radius" parameter with value 10
        var param1 = new GrasshopperDataTree("Radius");
        param1.Add("0", new List<GrasshopperObject> { new GrasshopperObject(10) });
        trees.Add(param1);

        // Add "Count" parameter with value 35
        var param2 = new GrasshopperDataTree("Count");
        param2.Add("0", new List<GrasshopperObject> { new GrasshopperObject(35) });
        trees.Add(param2);

        // Add "Length" parameter with value 35
        var param3 = new GrasshopperDataTree("Length");
        param3.Add("0", new List<GrasshopperObject> { new GrasshopperObject(35) });
        trees.Add(param3);

        // Evaluate the definition
        var result = GrasshopperCompute.EvaluateDefinition(definitionPath, trees);

        // Parse the result
        var data = result[0].InnerTree.First().Value[0].Data;
        var parsed = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
        var obj = Rhino.FileIO.File3dmObject.FromJSON(parsed);

        Console.WriteLine($"Result type: {obj.GetType()}");
    }
}
```

---

## Rhino Compute - Grasshopper Evaluation (Python)

Evaluates a Grasshopper definition using the Python compute_rhino3d library.

```python
# Python - Evaluate Grasshopper definition with Rhino Compute
import compute_rhino3d.Util
import compute_rhino3d.Grasshopper as gh
import rhino3dm
import json

# Configure server
compute_rhino3d.Util.url = "http://localhost:5000/"
# compute_rhino3d.Util.apiKey = "your-api-key"

# Create input geometry
pt1 = rhino3dm.Point3d(0, 0, 0)
circle = rhino3dm.Circle(pt1, 5)
angle = 20

# Convert circle to curve and encode as JSON
curve = json.dumps(circle.ToNurbsCurve().Encode())

# Create input parameter trees
curve_tree = gh.DataTree("curve")
curve_tree.Append([0], [curve])

rotate_tree = gh.DataTree("rotate")
rotate_tree.Append([0], [angle])

trees = [curve_tree, rotate_tree]

# Evaluate the Grasshopper definition
output = gh.EvaluateDefinition('twisty.gh', trees)

# Decode results
branch = output['values'][0]['InnerTree']['{0;0}']
lines = [rhino3dm.CommonObject.Decode(json.loads(item['data'])) for item in branch]

print(f'Created {len(lines)} lines')

# Save results to 3dm file
model = rhino3dm.File3dm()
for line in lines:
    model.Objects.AddCurve(line)
model.Write('output.3dm')
```

---

## Rhino Compute - Brep Meshing (JavaScript)

Uses Rhino Compute from the browser to mesh Brep geometry loaded from a 3dm file.

```javascript
// Browser - Load 3dm and mesh breps with Rhino Compute
import rhino3dm from 'rhino3dm'
import { RhinoCompute } from 'rhinocompute'

const rhino = await rhino3dm()

// Configure Rhino Compute
RhinoCompute.url = "https://compute.rhino3d.com/"
RhinoCompute.apiKey = "your-api-key"

// Load a 3dm file
const response = await fetch('model.3dm')
const buffer = await response.arrayBuffer()
const file3dm = rhino.File3dm.fromByteArray(new Uint8Array(buffer))
const objects = file3dm.objects()

// Process each Brep in the file
for (let i = 0; i < objects.count; i++) {
    const geometry = objects.get(i).geometry()

    if (geometry.objectType === rhino.ObjectType.Brep) {
        // Mesh the Brep on the server
        const result = await RhinoCompute.Mesh.createFromBrep(geometry)

        // Decode the mesh results
        const meshes = result.map(r => rhino.CommonObject.decode(r))
        console.log(`Brep ${i}: Created ${meshes.length} meshes`)

        // Get wireframe edges
        const wireframe = await RhinoCompute.Brep.getWireframe(geometry, 1)
        const curves = wireframe.map(r => rhino.CommonObject.decode(r))
        console.log(`Brep ${i}: ${curves.length} edge curves`)
    }
}
```

---

## Rhino.Inside - Embed Rhino in .NET Application

Embeds the Rhino geometry kernel inside a standalone .NET application without running Rhino.

```csharp
// C# - Use Rhino.Inside to mesh a sphere
using System;
using Rhino.Runtime.InProcess;
using Rhino.Geometry;

namespace HelloWorld
{
    class Program
    {
        static Program()
        {
            // Initialize the Rhino resolver
            RhinoInside.Resolver.Initialize();
        }

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                // Start Rhino core in-process
                using (new RhinoCore(args))
                {
                    MeshABrep();
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        static void MeshABrep()
        {
            // Create a sphere
            var sphere = new Sphere(Point3d.Origin, 12);
            var brep = sphere.ToBrep();

            // Mesh the Brep with specified parameters
            var mp = new MeshingParameters(0.5);
            var meshes = Mesh.CreateFromBrep(brep, mp);

            Console.WriteLine($"Created mesh with {meshes[0].Vertices.Count} vertices");
        }
    }
}
```

---

## Grasshopper - Custom Component (C#)

Creates a custom Grasshopper component that generates Platonic solid geometry.

```csharp
// C# - Grasshopper component for Tetrahedron
using System;
using Grasshopper.Kernel;

namespace SampleGhPlatonics.Components
{
    public class Tetrahedron : PlatonicComponentBase
    {
        // Constructor with component name, abbreviation, and description
        public Tetrahedron()
            : base("Tetrahedron", "U1", "Platonic solid with 4 faces")
        {
        }

        // Unique component GUID (required for all GH components)
        public override Guid ComponentGuid =>
            new Guid("3ACD41AE-5288-4B80-9E47-8E4976AEDF2C");

        // Returns the geometry generator
        public override PlatonicGeometryBase Geometry() =>
            new Geometry.Tetrahedron();

        // Component icon (24x24 bitmap)
        protected override System.Drawing.Bitmap Icon =>
            Properties.Resources.Tetrahedron_24x24;
    }
}
```

---

## openNURBS - Read 3DM File (C#)

Reads and validates a .3dm file using the openNURBS library for file I/O operations.

```csharp
// C# - Read and validate a 3dm file with openNURBS
using System;
using Rhino.FileIO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Syntax: example_read file.3dm");
            return;
        }

        string filename = args[0];
        Console.WriteLine($"OpenNURBS Archive File: {filename}");

        // Read the 3dm file
        using (var model = File3dm.Read(filename))
        {
            if (model == null)
            {
                Console.WriteLine("Unable to open file");
                return;
            }

            // Validate the model
            string dump;
            if (model.IsValid(out dump))
            {
                Console.WriteLine("Model is valid");
            }
            else
            {
                Console.WriteLine("Model is not valid");
                Console.Write(dump);
            }

            // Get model summary
            string summary = model.DumpSummary();
            Console.Write(summary.Replace("\t", "   "));

            // Access geometry objects
            var objects = model.Objects;
            Console.WriteLine($"Object count: {objects.Count}");

            foreach (var obj in objects)
            {
                var geometry = obj.Geometry;
                Console.WriteLine($"  - {geometry.ObjectType}");
            }
        }
    }
}
```

---

## Zoo Plugin - License Validation (C#)

Creates a LAN Zoo plugin for managing network licenses of Rhino plugins.

```csharp
// C# - Zoo license validation plugin
using System;
using Rhino.PlugIns;

namespace SampleCsZoo
{
    public class SampleCsZooClass : IZooPlugin
    {
        // Unique plugin ID
        public Guid ZooPluginId =>
            new Guid("YOUR-PLUGIN-GUID-HERE");

        // Plugin name displayed in Zoo
        public string Name => "Sample Zoo Plugin";

        // Validates a license key
        public ZooValidateResult ValidateLicense(string productKey)
        {
            // Example validation logic
            if (string.IsNullOrEmpty(productKey))
            {
                return new ZooValidateResult
                {
                    Result = ZooValidateResultCode.InvalidProductKey,
                    Message = "Product key cannot be empty"
                };
            }

            // Check key format (example: must start with "SAMPLE-")
            if (!productKey.StartsWith("SAMPLE-"))
            {
                return new ZooValidateResult
                {
                    Result = ZooValidateResultCode.InvalidProductKey,
                    Message = "Invalid product key format"
                };
            }

            return new ZooValidateResult
            {
                Result = ZooValidateResultCode.Success,
                LicenseCount = 1
            };
        }
    }
}
```

---

## Summary

The Rhino Developer Samples repository serves as the definitive resource for learning Rhino and Grasshopper development across multiple programming languages and platforms. Key use cases include: building Rhino plugins with RhinoCommon (C#, Python, VB.NET), creating standalone geometry applications with rhino3dm (Python, JavaScript, C#), developing Grasshopper components, processing geometry in the cloud with Rhino Compute, embedding Rhino's geometry engine in external applications with Rhino.Inside, and managing network licenses with Zoo plugins.

Integration patterns follow consistent conventions: RhinoCommon uses the `Rhino.Geometry` namespace for geometry creation and `scriptcontext.doc` for document access; rhino3dm provides a platform-independent geometry library loadable via npm or pip; Rhino Compute exposes REST APIs and client libraries for server-side geometry operations; and Grasshopper components inherit from base classes like `GH_Component` with standardized input/output parameter registration. The repository is versioned by git branches (master for WIP, numbered branches like `7` and `6` for stable Rhino versions), making it easy to find samples compatible with specific Rhino releases.

