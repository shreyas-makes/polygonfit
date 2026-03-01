# PolygonFit Rhino v1 Specification

## Objective
Build a RhinoCommon C# command plugin for Rhino 7 and Rhino 8 that cleans polygonal city-map data from a selected layer and reduces manual correction effort for area workflows.

## Scope (v1)
- Platform: Rhino 7 and Rhino 8.
- Input selection: one user-selected Rhino layer.
- Accepted input geometry on that layer:
  - Closed polylines.
  - Closed curves (converted to working polylines for processing).
- Processing plane: World XY only.
  - Non-planar or non-XY-embedded inputs are skipped and treated as warnings.
- Interaction model: preview first, then apply/cancel.
- Write mode: in-place replacement on apply.

## Cleanup Goals
- Remove duplicate polygons.
- Remove sliver polygons.
- Resolve overlaps by prioritizing larger polygons.
- Snap adjacent poly-vertices and near-coincident boundaries to shared topology.
- Reduce micro-gaps via vertex/edge snapping under tolerance.
- Detect holes/islands and flag them for review (do not auto-resolve).

## Tolerance and Threshold Profile (Meters-Based)
- Vertex snap tolerance: `0.001 m`
- Overlap / near-coincident boundary merge tolerance: `0.0005 m`
- Gap-close tolerance: `0.001 m`
- Minimum segment length cleanup: `0.0005 m`
- Sliver area threshold: `15 cm^2` (`0.0015 m^2`)
- Angle simplification threshold: `2.0 deg`

## Processing Rules
1. Layer scan
- Collect only closed curves from the chosen layer.
- Ignore open curves and unsupported objects.

2. Geometry normalization
- Convert accepted curves to closed polyline representation.
- Ensure closed loop semantics and consistent XY processing.

3. Global snapping
- Snap vertices globally using vertex snap tolerance.
- Snap vertices to nearby edges using gap-close tolerance.
- Merge near-coincident boundary vertices using merge tolerance.

4. Polyline cleanup
- Remove adjacent micro-segments shorter than minimum segment length.
- Apply conservative angle-based simplification (`2 deg`).

5. Duplicate removal
- Detect duplicates within tolerance (including reversed direction cases).
- Keep one representative polygon, mark others for deletion.

6. Sliver removal
- Compute polygon area in XY.
- Delete polygons with area `< 0.0015 m^2`.

7. Overlap handling
- Detect pairwise overlap regions.
- Preserve larger polygon; mark smaller conflicting polygons for deletion.

8. Hole/island detection
- Detect nested loops (polygon inside polygon).
- Do not auto-modify those cases.
- Flag for review layer output.

## Command Flow
1. Run command: `CleanCityPolygons`.
2. Prompt user for target layer.
3. Build cleaned preview result:
- Keep/update set.
- Delete set (sliver, duplicate, overlap-prioritized).
- Flagged set (holes/islands).
4. Show preview geometry in temporary preview layer.
5. Prompt user: Apply or Cancel.
6. If Apply:
- Replace eligible originals in-place with cleaned curves.
- Delete marked originals.
- Keep flagged ambiguous originals unchanged.
- Write flagged copies to review layer.
7. If Cancel:
- Remove preview output and leave document unchanged.

## Outputs
- Preview layer (temporary).
- Review layer for hole/island flags.
- In-place cleaned layer content on apply.

## Non-Goals (v1)
- Full arbitrary 3D topology cleaning.
- Automatic hole/island topology reconstruction.
- Cross-layer topology reconciliation.
- AutoCAD plugin implementation (future phase).

## Acceptance Criteria
- Input layer is processed without modifying other layers.
- Adjacent polygon vertices/boundaries are snapped within tolerance profile.
- Duplicate polygons are removed within tolerance.
- Sliver polygons smaller than `15 cm^2` are removed.
- Overlap conflicts prefer larger polygons.
- Hole/island ambiguities are flagged (not silently altered).
- Apply/Cancel preview flow works; cancel has no document changes.

## Risks and Notes
- Extremely strict tolerances can under-correct noisy source data.
- Pairwise overlap logic may require optimization for very large datasets.
- Rhino document unit settings should be meters for this profile.
