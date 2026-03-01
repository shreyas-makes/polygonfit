# PolygonFit Rhino Plugin (v1)

## Command
- `CleanCityPolygons`

## What it does
- Cleans closed curves/polylines on a selected layer.
- Uses preview-then-apply workflow.
- Removes duplicates, slivers, overlaps (smaller polygon removed), and degenerate outputs.
- Snaps adjacent vertices/edges using strict city-planning tolerances.
- Flags hole/island ambiguities to `_PolygonFit_Review`.

## Tolerances
- Vertex snap: `0.001 m`
- Near-coincident merge: `0.0005 m`
- Gap-close: `0.001 m`
- Minimum segment length: `0.0005 m`
- Sliver threshold: `15 cm^2` (`0.0015 m^2`)
- Angle simplification: `2 deg`

## Build notes
- Target framework: `net48`
- RhinoCommon package: `7.34.23267.13001`
- Intended for Rhino 7 and Rhino 8 compatibility.
