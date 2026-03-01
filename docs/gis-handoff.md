# GIS Handoff Checklist

Use this checklist after cleaning polygons in Rhino to avoid reintroducing topology issues in GIS.

## 1) Keep units and CRS consistent

- Work in meters in Rhino.
- Export to a projected CRS in meters (not geographic degrees) before topology QA.

## 2) Prefer GeoPackage over Shapefile

- GeoPackage preserves schema better and avoids shapefile field/encoding limitations.

## 3) Apply precision control in GIS

- Snap vertices to a fixed grid equal to production precision.
- For this workflow, a common value is `0.001 m`.

## 4) Run validity checks before publishing

- In QGIS: run `Check validity`, then `Fix geometries` as needed.

## 5) Run overlap/gap topology rules

- Must not overlap.
- Must not have gaps (for wall-to-wall parcel coverage).

## 6) If using PostGIS, validate in SQL

```sql
-- invalid geometries
SELECT id FROM parcels WHERE NOT ST_IsValid(geom);

-- self/peer overlaps
SELECT a.id, b.id
FROM parcels a
JOIN parcels b ON a.id < b.id
WHERE ST_Overlaps(a.geom, b.geom);
```

## 7) Keep one tolerance policy across tools

- Rhino cleanup tolerance and GIS precision/snapping should match.
- Mismatched tolerances can reintroduce tiny artifacts.
