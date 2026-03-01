# Polygonfit 

<img width="1536" height="1024" alt="ChatGPT Image Mar 1 2026 from Rhino Plugin Development" src="https://github.com/user-attachments/assets/cb23b7f8-5273-4077-afa3-7740e4f55ccd" />

PolygonFit is a Rhino plugin that cleans closed polygon boundaries for city-planning workflows.

It helps reduce manual cleanup by handling:
- duplicate polygons
- slivers
- overlaps
- micro-gaps / near-coincident boundaries
- hole/island ambiguities (flagged for review)

Primary command:
- `CleanCityPolygons`

## Quick Start for Windows

If you only want to use the plugin in Rhino, this is the path to follow.

1. Get the prebuilt Windows package:
- `dist/PolygonFit-rhino-windows.zip`

2. Extract the zip. You should have:
- `PolygonFit.dll`
- `PolygonFit.Core.dll`

3. Keep both files in the same folder.

4. Install in Rhino (Rhino 7 or 8):
- Open `PlugInManager`
- Click `Install...`
- Select `PolygonFit.dll`

5. If Rhino does not accept `.dll`, copy/rename `PolygonFit.dll` to `PolygonFit.rhp` and install that file.

6. Restart Rhino.

7. Run command:
- `CleanCityPolygons`

## Rhino User Journey

This is the typical end-to-end flow inside Rhino.

1. Prepare your layer
- Put target closed boundaries on a single layer.
- Ensure model units are meters (recommended for default tolerance profile).

2. Run cleanup
- Run `CleanCityPolygons`.
- Enter or select the target layer when prompted.

3. Review preview output
- The plugin runs in preview mode first.
- Color meanings:
- green: keep
- red: delete candidate (duplicate/sliver/overlap/degenerate)
- gold: hole/island ambiguity (manual review recommended)

4. Inspect generated layers
- `_PolygonFit_Preview`: temporary preview geometry
- `_PolygonFit_Review`: flagged hole/island cases

5. Decide
- `Apply`: commits cleanup in-place on the target layer
- `Cancel`: exits without changing model geometry

6. Validate before export
- Check gold review cases manually.
- Confirm expected parcels remain and obvious slivers/duplicates are removed.

## What v1 Does

- Input: one selected Rhino layer containing closed curves/polylines.
- Processing plane: World XY (non-planar inputs are skipped).
- Interaction: preview first, then `Apply` or `Cancel`.
- Apply mode: in-place update.
- Hole/island ambiguities: flagged to review layer (not auto-resolved).

### Default Tolerances (meters)

- Vertex snap: `0.001`
- Near-coincident merge: `0.0005`
- Gap close: `0.001`
- Minimum segment length: `0.0005`
- Sliver threshold: `15 cm^2` (`0.0015 m^2`)
- Angle simplification: `2 deg`


## Documentation

- Product specification: [`docs/spec.md`](docs/spec.md)
- GIS handoff checklist: [`docs/gis-handoff.md`](docs/gis-handoff.md)

## License

MIT. See [`LICENSE`](LICENSE).
