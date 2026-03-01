# PolygonFit (Rhino Plugin)

PolygonFit is a Rhino plugin to clean closed polygon boundaries for city-planning workflows.

It targets:
- duplicate polygons
- slivers
- overlaps
- micro-gaps / near-coincident boundaries
- ambiguous holes/islands (flagged for manual review)

Primary command:
- `CleanCityPolygons`

## Current v1 Behavior

- Input: one selected Rhino layer containing closed curves/polylines.
- Plane: World XY (non-planar inputs are skipped).
- Flow: preview first, then `Apply` or `Cancel`.
- Apply mode: in-place update.
- Hole/island ambiguities: flagged to review layer.

### Tolerances (meters)
- Vertex snap: `0.001`
- Near-coincident merge: `0.0005`
- Gap close: `0.001`
- Minimum segment length: `0.0005`
- Sliver threshold: `15 cm^2` (`0.0015 m^2`)
- Angle simplification: `2 deg`

## Windows + Rhino Setup (Friend Laptop)

Single packaged output is available at:
- `dist/PolygonFit-rhino-windows.zip`

## Option A: Use Prebuilt Plugin (recommended for non-dev)

1. Get release files from this repo (or ask for a zip) containing:
- `PolygonFit.dll`
- `PolygonFit.Core.dll`

2. Put both files in the same folder on the Windows laptop.

3. In Rhino (7 or 8):
- open `PlugInManager`
- click `Install...`
- pick `PolygonFit.dll`

4. If Rhino refuses `.dll`, duplicate/rename it to `PolygonFit.rhp` and install that file instead.

5. Restart Rhino and run command:
- `CleanCityPolygons`

## Option B: Build From Source (Windows)

Prerequisites:
- Rhino 7 or Rhino 8 installed
- Visual Studio 2022 (Desktop development with .NET)
- .NET Framework 4.8 Developer Pack
- .NET SDK (used for tests/build tooling)

Build steps (PowerShell in repo root):

```powershell
dotnet restore .\src\PolygonFit\PolygonFit.csproj
dotnet build .\src\PolygonFit\PolygonFit.csproj -c Release
```

Plugin output:
- `src\PolygonFit\bin\Release\net48\PolygonFit.dll`
- `src\PolygonFit\bin\Release\net48\PolygonFit.Core.dll`

Install in Rhino as in Option A.

### Regenerate the Windows package

```bash
./scripts/package-windows.sh
```

## How to Use in Rhino

1. Run `CleanCityPolygons`.
2. Enter/select the target layer name.
3. Review preview colors:
- green: keep
- red: delete candidate (duplicate/sliver/overlap/degenerate)
- gold: hole/island ambiguity (review)
4. Choose:
- `Apply`: commit cleanup in-place
- `Cancel`: no model changes

Created layers:
- `_PolygonFit_Preview` (temporary preview geometry)
- `_PolygonFit_Review` (flagged hole/island cases)

## GIS Handoff (to avoid reintroducing topology issues)

When exporting cleaned polygons to GIS, do this checklist:

1. Keep units/CRS consistent
- Work in meters in Rhino.
- Export to a projected CRS in meters (not geographic degrees) before topology QA.

2. Prefer GeoPackage over Shapefile
- GeoPackage preserves schema better and avoids shapefile limitations.

3. Apply precision control in GIS
- Snap vertices to a fixed grid equal to your production precision (for this workflow, typically `0.001 m`).

4. Run GIS validity checks
- `Check validity` then `Fix geometries` (QGIS) before publishing.

5. Run overlap/gap checks in GIS topology rules
- Must not overlap.
- Must not have gaps (if wall-to-wall parcels are expected).

6. If using PostGIS, validate in SQL

```sql
-- invalid geometries
SELECT id FROM parcels WHERE NOT ST_IsValid(geom);

-- self/peer overlaps
SELECT a.id, b.id
FROM parcels a
JOIN parcels b ON a.id < b.id
WHERE ST_Overlaps(a.geom, b.geom);
```

7. Keep a single tolerance policy across tools
- Rhino cleanup tolerance and GIS snapping/precision must match, otherwise tiny artifacts can reappear.

## Test Status

Core geometry logic has unit tests in:
- `tests/PolygonFit.Core.Tests`

Run:

```bash
dotnet test tests/PolygonFit.Core.Tests/PolygonFit.Core.Tests.csproj -c Release
```

## Notes

- RhinoCommon package may resolve to a close patch version during restore.
- Runtime validation with real city-map datasets is still recommended before production rollout.

## References

- Product specification: [`docs/spec.md`](docs/spec.md)
