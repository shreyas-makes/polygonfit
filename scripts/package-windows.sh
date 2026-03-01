#!/usr/bin/env bash
set -euo pipefail

ROOT="$(cd "$(dirname "$0")/.." && pwd)"
OUT_DIR="$ROOT/dist/PolygonFit-rhino-windows"
ZIP_PATH="$ROOT/dist/PolygonFit-rhino-windows.zip"
BUILD_DIR="$ROOT/src/PolygonFit/bin/Release/net48"

rm -rf "$OUT_DIR"
mkdir -p "$OUT_DIR"

cp "$BUILD_DIR/PolygonFit.dll" "$OUT_DIR/"
cp "$BUILD_DIR/PolygonFit.Core.dll" "$OUT_DIR/"

cat > "$OUT_DIR/INSTALL_WINDOWS.txt" <<'TXT'
PolygonFit Rhino Plugin (Windows install)

Files in this folder:
- PolygonFit.dll (Rhino plugin)
- PolygonFit.Core.dll (required dependency)

Install:
1) Keep both DLL files in the same folder.
2) Open Rhino 7 or Rhino 8.
3) Open PlugInManager.
4) Click Install... and select PolygonFit.dll.
5) Restart Rhino.
6) Run command: CleanCityPolygons

If Rhino refuses .dll, rename PolygonFit.dll to PolygonFit.rhp and install that.
TXT

rm -f "$ZIP_PATH"
cd "$ROOT/dist"
zip -r "$(basename "$ZIP_PATH")" "$(basename "$OUT_DIR")" >/dev/null

echo "Created: $ZIP_PATH"
