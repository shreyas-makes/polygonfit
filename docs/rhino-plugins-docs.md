### Rhino.PlugIns.PlugIn.IdFromName

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/idfromname

Gets the Guid of an installed plug-in by its name.

```APIDOC
## Rhino.PlugIns.PlugIn.IdFromName

### Description
Gets the id of an installed plug-in giving the plug-in's name.

### Method
`public static Guid IdFromName(String pluginName)`

### Endpoint
N/A (This is a static method within the RhinoCommon library)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// Example usage within a RhinoCommon context
string pluginNameToFind = "MyCustomPlugin";
Guid pluginId = Rhino.PlugIns.PlugIn.IdFromName(pluginNameToFind);

if (pluginId != Guid.Empty)
{
    // Plugin found, pluginId contains the Guid
    Rhino.RhinoApp.WriteLine($"Found plugin '{pluginNameToFind}' with ID: {pluginId}");
}
else
{
    // Plugin not found
    Rhino.RhinoApp.WriteLine($"Plugin '{pluginNameToFind}' not found.");
}
```

### Response
#### Success Response (200)
- **Guid** - The unique identifier (Guid) of the plug-in if found.

#### Response Example
```json
"a1b2c3d4-e5f6-7890-1234-567890abcdef"
```

#### Error Response
- If the pluginName does not correspond to an installed plug-in, an empty Guid (`Guid.Empty`) may be returned or an exception could be thrown depending on the library's implementation details. It's recommended to check the returned Guid against `Guid.Empty`.
```

--------------------------------

### Rhino.Render.PreviewBackground.SetUpPreview Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewbackground/setuppreview

The SetUpPreview method initializes the preview background for a given scene and GUID.

```APIDOC
## Rhino.Render.PreviewBackground.SetUpPreview

### Description
Initializes the preview background for a given scene server and object identifier.

### Method
Public Void

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "sceneServerPointer": "IntPtr",
  "guid": "Guid"
}
```

### Response
#### Success Response (Void)
This method does not return a value.

#### Response Example
None
```

--------------------------------

### Rhino.Runtime.Skin.OnBeginLoadAtStartPlugIns

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.skin/onbeginloadatstartplugins

This method is invoked when the initial plug-in scheduled to load at startup is processed.

```APIDOC
## OnBeginLoadAtStartPlugIns method

### Description
Is called when the first plug-in that loads at start-up is going to be loaded.

### Method
protected virtual Void OnBeginLoadAtStartPlugIns

### Endpoint
Rhino.Runtime.Skin.OnBeginLoadAtStartPlugIns

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "No request body needed for this method."
}
```

### Response
#### Success Response (200)
- **Void** - This method does not return a value.

#### Response Example
```json
{
  "example": "No response body returned."
}
```
```

--------------------------------

### Get TurbulenceTextureType Guid

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/turbulencetexturetype

Retrieves the Guid identifier for the Turbulence texture type using the RhinoCommon API. This property is static and read-only, returning a Guid value. It is available starting from version 6.0.

```csharp
public static Guid TurbulenceTextureType {get}
```

--------------------------------

### SetUpPreview Method Signature (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewgeometry/setuppreview

The SetUpPreview method is used to set up the preview of render content. It takes a scene server pointer, a render content pointer, and a boolean flag indicating whether to copy the content. This method returns void and is available in RhinoCommon version 6.0 and later.

```csharp
public Void SetUpPreview(
  IntPtr sceneServerPointer,
  IntPtr pRenderContent,
  Boolean bCopy
)
```

--------------------------------

### Get EXRTextureType Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/exrtexturetype

Retrieves the Guid identifier for EXR texture types within the Rhino.Render.ContentUuids class. This property is read-only and returns a Guid value. It is available starting from Rhino version 6.0.

```csharp
System.Guid result = Rhino.Render.ContentUuids.EXRTextureType;
```

--------------------------------

### SetUpPreview Method Signature (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewlighting/setuppreview

The SetUpPreview method is part of the Rhino.Render.PreviewLighting class. It is used to set up the preview lighting for a scene. This method takes an IntPtr representing the scene server pointer as input and returns void. It has been available since Rhino version 6.0.

```csharp
public Void SetUpPreview(
IntPtr sceneServerPointer
)
```

--------------------------------

### GET /Rhino.PlugIns/PlugIn/GetPlugInInfo

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getplugininfo

This endpoint retrieves detailed information about an installed Rhino plug-in, identified by its unique Guid.

```APIDOC
## GET /Rhino.PlugIns/PlugIn/GetPlugInInfo

### Description
Returns detailed information about an installed Rhino plug-in.

### Method
GET

### Endpoint
/Rhino.PlugIns/PlugIn/GetPlugInInfo

### Parameters
#### Query Parameters
- **pluginId** (System.Guid) - Required - The id of the plug-in.

### Request Example
```json
{
  "pluginId": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

### Response
#### Success Response (200)
- **PlugInInfo** (PlugInInfo) - Detailed information about an installed Rhino plug-in if successful.

#### Response Example
```json
{
  "Name": "MyPlugin",
  "Version": "1.0.0.0",
  "Author": "RhinoDeveloper",
  "Guid": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```
```

--------------------------------

### SetUpperLimit Method - C# Example

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getnumber/setupperlimit

This C# example demonstrates how to use the SetUpperLimit method to restrict the maximum acceptable number input. The strictlyLessThan parameter controls whether the limit is inclusive or exclusive.

```csharp
public Void SetUpperLimit(
  Double upperLimit,
  Boolean strictlyLessThan
)
```

--------------------------------

### Get ContentTypeId Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.datasources.contentfactory/contenttypeid

The ContentTypeId method in the Rhino.Render.DataSources.ContentFactory class returns a Guid that identifies the content type. This method is part of the RhinoCommon API and is available starting from version 6.7.

```csharp
public Guid ContentTypeId()

```

--------------------------------

### ShortcutKeySettings() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.shortcutkeysettings/shortcutkeysettings

Initializes a new instance of the ShortcutKeySettings class.

```APIDOC
## ShortcutKeySettings()

### Description
Initializes a new instance of the ShortcutKeySettings class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (200)
Initializes a ShortcutKeySettings object.

#### Response Example
```json
{
  "instance": "ShortcutKeySettings object"
}
```
```

--------------------------------

### Get All Installed Plug-ins (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getinstalledplugins

Retrieves a dictionary of all registered plug-ins, identified by their GUID, along with their localized names. This method is available since RhinoCommon version 5.0.

```csharp
public static Dictionary<Guid, string> GetInstalledPlugIns()
{
  // Implementation details omitted
  return new Dictionary<Guid, string>();
}
```

--------------------------------

### Rhino.Render.PreviewGeometry.SetUpPreview

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewgeometry/setuppreview

The SetUpPreview method in the Rhino.Render.PreviewGeometry class allows for setting up a preview, taking scene server and render content pointers, and a boolean flag for copying.

```APIDOC
## Rhino.Render.PreviewGeometry.SetUpPreview

### Description
Sets up a preview with the provided scene server, render content, and a copy flag.

### Method
Public Void

### Endpoint
Rhino.Render.PreviewGeometry.SetUpPreview

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **sceneServerPointer** (IntPtr) - Required - Pointer to the scene server.
- **pRenderContent** (IntPtr) - Required - Pointer to the render content.
- **bCopy** (Boolean) - Required - Flag indicating whether to copy the content.

### Request Example
```json
{
  "sceneServerPointer": "<IntPtr_Value>",
  "pRenderContent": "<IntPtr_Value>",
  "bCopy": true
}
```

### Response
#### Success Response (Void)
This method does not return a value.

#### Response Example
None
```

--------------------------------

### Get Plug-in Object by GUID - C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/getpluginobject

Retrieves a plug-in object using its unique GUID. This function requires the plug-in to be installed in Rhino. It calls the plug-in's GetPlugInObject function and returns the result.

```csharp
public static Object GetPlugInObject(
  Guid pluginId
)
```

--------------------------------

### FileSkpReadOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileskpreadoptions/fileskpreadoptions

Initializes a new instance of the FileSkpReadOptions class.

```APIDOC
## FileSkpReadOptions()

### Description
Initializes a new instance of the FileSkpReadOptions class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
#### Success Response (Instance)
- **FileSkpReadOptions** (Object) - An initialized instance of the FileSkpReadOptions class.

#### Response Example
```json
{
  "message": "FileSkpReadOptions instance created"
}
```
```

--------------------------------

### Get MenuId Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.ruiupdateui/menuid

Retrieves the unique identifier (Guid) of the menu that owns this menu item. This property is read-only and returns a Guid value. It is available starting from version 5.11 of the RhinoCommon API.

```csharp
public Guid MenuId {get}
```

--------------------------------

### Get Plug-in Path from ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/pathfromid

Retrieves the installation path of a Rhino plug-in using its unique identifier (Guid). This method is part of the Rhino.PlugIns.PlugIn class and is available since RhinoCommon version 5.9.

```csharp
public static String PathFromId( Guid pluginId )
```

--------------------------------

### DisplayDeviceInfo Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.displaydeviceinfo/displaydeviceinfo

Initializes a new instance of the DisplayDeviceInfo class.

```APIDOC
## DisplayDeviceInfo Constructor

### Description
Initializes a new instance of the DisplayDeviceInfo class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "DisplayDeviceInfo()"
}
```

### Response
#### Success Response (Initialization)
- **Instance** (DisplayDeviceInfo) - A new instance of the DisplayDeviceInfo class.

#### Response Example
```json
{
  "example": "// Object instantiation in C#\nDisplayDeviceInfo deviceInfo = new DisplayDeviceInfo();"
}
```
```

--------------------------------

### Get BlendMaterialType Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/blendmaterialtype

Retrieves the Guid representing the BlendMaterialType. This property is available starting from Rhino version 6.0. It is a static property of the Rhino.Render.ContentUuids class.

```csharp
public static Guid BlendMaterialType {get}
```

--------------------------------

### InitializeRhinoCommon

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_HostUtils

Ensures all static RhinoCommon components are set up correctly.

```APIDOC
## InitializeRhinoCommon

### Description
Makes sure all static RhinoCommon components is set up correctly. This happens automatically when a plug-in is loaded, so you probably won't have to call this method.

### Method
N/A (Function signature)

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
None
```

--------------------------------

### Get RenderEngineId (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmrendercontent/renderengineid

Retrieves the unique identifier for the render engine associated with the content. This property is read-only and returns a Guid. It is available starting from RhinoCommon version 8.0.

```csharp
public Guid RenderEngineId { get; }
```

--------------------------------

### Get Installed Plug-ins with Name Localization Option (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getinstalledplugins

Retrieves a dictionary of all registered plug-ins, identified by their GUID, with an option to specify whether to return the localized or English name. This overload is available since RhinoCommon version 7.5.

```csharp
public static Dictionary<Guid, string> GetInstalledPlugIns(bool localizedPlugInName)
{
  // Implementation details omitted
  return new Dictionary<Guid, string>();
}
```

--------------------------------

### GUID Settings API

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_PersistentSettings

Methods for getting and setting Globally Unique Identifier (GUID) values.

```APIDOC
## GET /api/settings/guid

### Description
Retrieves a GUID value associated with a given key.

### Method
GET

### Endpoint
/api/settings/guid

### Parameters
#### Query Parameters
- **key** (string) - Required - The key for the GUID value.

### Response
#### Success Response (200)
- **value** (string) - The retrieved GUID value.

#### Response Example
```json
{
  "value": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

## SET /api/settings/guid

### Description
Sets a GUID value associated with a given key.

### Method
POST

### Endpoint
/api/settings/guid

### Parameters
#### Request Body
- **key** (string) - Required - The key for the GUID value.
- **value** (string) - Required - The GUID value to set.

### Request Example
```json
{
  "key": "uniqueId",
  "value": "f0e9d8c7-b6a5-4321-fedc-ba9876543210"
}
```

### Response
#### Success Response (200)
- **message** (string) - Confirmation message.

#### Response Example
```json
{
  "message": "GUID value set successfully."
}
```
```

--------------------------------

### Ray3d Position Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.ray3d/position

Gets the starting position of this ray.

```APIDOC
## Ray3d.Position Property

### Description
Gets the starting position of this ray.

### Method
Get

### Endpoint
Rhino.Geometry.Ray3d.Position

### Parameters

#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Position** (Point3d) - The starting 3D point of the ray.

#### Response Example
```json
{
  "Position": {
    "X": 0.0,
    "Y": 0.0,
    "Z": 0.0
  }
}
```

### Remarks
Available since RhinoCommon version 5.0.
```

--------------------------------

### Rhino.Runtime.Skin.OnBeginLoadPlugIn

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.skin/onbeginloadplugin

This method is invoked when a specific plug-in is about to be loaded. It receives a string describing the plug-in.

```APIDOC
## OnBeginLoadPlugIn method

### Description
Is called when a specific plug-in is going to be loaded.

### Method
`protected virtual void OnBeginLoadPlugIn(string description)`

### Parameters
#### Parameters
- **description** (System.String) - The plug-in description.

### Returns
Type: Void
```

--------------------------------

### SimpleArrayBrepPointer Constructor

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_InteropWrappers_SimpleArrayBrepPointer

Initializes a new SimpleArrayBrepPointer instance.

```APIDOC
## SimpleArrayBrepPointer()

### Description
Initializes a new <b>SimpleArrayBrepPointer</b> instance.

### Method
CONSTRUCTOR

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
N/A

#### Response Example
None
```

--------------------------------

### Get ParentId Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.namehash/parentid

The ParentId property returns a Guid representing the parent identifier. This is primarily useful when the object participates in a hierarchical structure, such as layers in Rhino. It is available starting from RhinoCommon version 6.0.

```csharp
public Guid ParentId { get; }
```

--------------------------------

### IZooClientUtilities.ShowBuyLicenseUi

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.izooclientutilities/showbuylicenseui

Displays the UI for purchasing a license. This method is protected and returns void.

```APIDOC
## IZooClientUtilities.ShowBuyLicenseUi

### Description
Displays the user interface for purchasing a license. This is a protected method and does not return any value.

### Method
Void

### Endpoint
Rhino.Runtime.IZooClientUtilities

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **verify** (Object) - Required - Description not specified.
- **productId** (Guid) - Required - The unique identifier for the product license.

### Request Example
```json
{
  "verify": null, 
  "productId": "00000000-0000-0000-0000-000000000000"
}
```

### Response
#### Success Response (200)
Type: Void

#### Response Example
None (Void return type)
```

--------------------------------

### Get Plug-in Object by Name - C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/getpluginobject

Retrieves a plug-in object using its name. Similar to the GUID version, this function requires the plug-in to be installed. It finds the plug-in by name, calls its GetPlugInObject function, and returns the object.

```csharp
public static Object GetPlugInObject(
  String plugin
)
```

--------------------------------

### CursorTooltipSettings() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.cursortooltipsettings/cursortooltipsettings

Initializes a new instance of the CursorTooltipSettings class.

```APIDOC
## CursorTooltipSettings()

### Description
Initializes a new instance of the CursorTooltipSettings class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{}
```

### Response
#### Success Response (200)
An instance of CursorTooltipSettings.

#### Response Example
```json
{
  "example": "CursorTooltipSettings object"
}
```
```

--------------------------------

### Rhino.Render.PostEffects.PostEffectUuids.Dithering

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectuuids/dithering

Gets the Guid for the Dithering post-effect.

```APIDOC
## Rhino.Render.PostEffects.PostEffectUuids.Dithering

### Description
Gets the unique identifier (Guid) for the Dithering post-effect.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Render.PostEffects/PostEffectUuids/Dithering

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Dithering** (Guid) - The Guid for the Dithering post-effect.

#### Response Example
{
  "Dithering": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}

### Remarks
Available since version 8.13.
```

--------------------------------

### InitializeRhinoCommon_RDK

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_HostUtils

Ensures all static RhinoCommon RDK components are set up correctly.

```APIDOC
## InitializeRhinoCommon_RDK

### Description
Makes sure all static RhinoCommon RDK components are set up correctly. This happens automatically when the RDK is loaded, so you probably won't have to call this method.

### Method
N/A (Function signature)

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
None
```

--------------------------------

### Get RenderTexture from Instance ID - C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.changequeue.changequeue/texturefromoriginalinstanceid

Retrieves a RenderTexture from the ChangeQueue content cache using the specified original instance ID. This method is available starting from RhinoCommon version 8.5. It takes a Guid as input and returns a RenderTexture object.

```csharp
public RenderTexture TextureFromOriginalInstanceId(Guid id)
```

--------------------------------

### FileGHSReadOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileghsreadoptions/fileghsreadoptions

Initializes a new instance of the FileGHSReadOptions class.

```APIDOC
## FileGHSReadOptions()

### Description
Initializes a new instance of the FileGHSReadOptions class.

### Method
### Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "FileGHSReadOptions()"
}
```

### Response
#### Success Response (N/A)
This is a constructor, it does not return a value.

#### Response Example
N/A
```

--------------------------------

### OperatingSystemInstallationType Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/operatingsysteminstallationtype

Returns the operating system installation type. This can be 'Client', 'Server', or 'Unknown'.

```APIDOC
## OperatingSystemInstallationType Property

### Description
Returns the Operating System Installation Type. Possible values are "Client", "Server", or "Unknown".

### Method
GET

### Endpoint
/Rhino.Runtime/HostUtils/OperatingSystemInstallationType

### Parameters
None

### Request Body
None

### Response
#### Success Response (200)
- **string** (string) - The operating system installation type.

#### Response Example
{
  "OperatingSystemInstallationType": "Client"
}
```

--------------------------------

### ViewSettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.viewsettings/viewsettings

Initializes a new instance of the ViewSettings class.

```APIDOC
## ViewSettings()

### Description
Initializes a new instance of the ViewSettings class.

### Method
* (Constructor)

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Body
None

### Request Example
```csharp
var viewSettings = new Rhino.ApplicationSettings.ViewSettings();
```

### Response
#### Success Response
Initializes a ViewSettings object.

#### Response Example
```csharp
// No direct response, object is created in memory.
```
```

--------------------------------

### Get or Set Initial Directory in OpenFileDialog (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.openfiledialog/initialdirectory

The InitialDirectory property of the Rhino.UI.OpenFileDialog class allows you to specify the starting directory that will be displayed when the file dialog is opened. This is useful for guiding users to a specific location. It returns or accepts a string representing the directory path.

```csharp
public string InitialDirectory {get|set}
```

--------------------------------

### FileTxtWriteOptions() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filetxtwriteoptions/filetxtwriteoptions

Initializes a new instance of the FileTxtWriteOptions class with default settings.

```APIDOC
## FileTxtWriteOptions()

### Description
Initializes a new instance of the FileTxtWriteOptions class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "FileTxtWriteOptions()"
}
```

### Response
#### Success Response (Instance)
- **FileTxtWriteOptions** (FileTxtWriteOptions) - An initialized instance of the FileTxtWriteOptions class.

#### Response Example
```json
{
  "example": "<Rhino.FileIO.FileTxtWriteOptions object>"
}
```
```

--------------------------------

### Get Guid by Index - C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.interopwrappers.simplearrayguid/item

Retrieves a Guid from the SimpleArrayGuid collection using its integer index. This property is part of the RhinoCommon API for accessing GUID arrays.

```csharp
public Guid this[int index]
{
  get;
}
```

--------------------------------

### InitializeZooClient

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_HostUtils

Initializes the ZooClient and Rhino license manager.

```APIDOC
## InitializeZooClient

### Description
Initializes the ZooClient and Rhino license manager, this should get called automatically when RhinoCommon is loaded so you probably won't have to call this method.

### Method
N/A (Function signature)

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
None
```

--------------------------------

### Get StuccoTextureType Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/stuccotexturetype

Retrieves the static Guid for the StuccoTextureType. This property is part of the Rhino.Render.ContentUuids class and is available from Rhino version 6.0 onwards. It returns a Guid.

```csharp
public static Guid StuccoTextureType { get; }
```

--------------------------------

### FileFbx Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filefbx/filefbx

Initializes a new instance of the FileFbx class.

```APIDOC
## FileFbx Constructor

### Description
Initializes a new instance of the FileFbx class.

### Method
Constructor

### Endpoint
Rhino.FileIO.FileFbx()

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{
  "example": "FileFbx()"
}
```

### Response
#### Success Response (200)
This constructor does not return a value, but initializes an object of type FileFbx.

#### Response Example
```json
{
  "example": "Initialized FileFbx object"
}
```
```

--------------------------------

### Get DisplayAttributeMaterialType Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/displayattributematerialtype

Retrieves the static Guid for the DisplayAttributeMaterialType. This property is part of the Rhino.Render.ContentUuids class and is available since Rhino version 7.5. It returns a Guid value.

```csharp
public static Guid DisplayAttributeMaterialType { get; }
```

--------------------------------

### Rhino.Display.DisplayModeDescription.MonochromeId

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaymodedescription/monochromeid

Gets the Guid identifier for the monochrome display mode.

```APIDOC
## Rhino.Display.DisplayModeDescription.MonochromeId

### Description
Gets the Guid identifier for the monochrome display mode.

### Method
GET

### Endpoint
Rhino.Display.DisplayModeDescription.MonochromeId

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
- **MonochromeId** (Guid) - The Guid for the monochrome display mode.

#### Response Example
```json
{
  "MonochromeId": "some-guid-value"
}
```

### Remarks
Available since RhinoCommon version 8.14.
```

--------------------------------

### HostUtils Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/hostutils

Initializes a new instance of the HostUtils class.

```APIDOC
## HostUtils Constructor

### Description
Initializes a new instance of the HostUtils class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "new HostUtils()"
}
```

### Response
#### Success Response (N/A)
This is a constructor, it does not return a value directly.

#### Response Example
```json
{
  "example": "Instance of HostUtils created."
}
```
```

--------------------------------

### RhinoCommon API: Get BasicEnvironmentCCI Guid

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/basicenvironmentcci

Retrieves the static Guid for the BasicEnvironmentCCI. This property is part of the Rhino.Render.ContentUuids class and is available since Rhino 6.0. It returns a Guid object.

```csharp
public static Guid BasicEnvironmentCCI {get}
```

--------------------------------

### CursorTooltipSettingsState Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.cursortooltipsettingsstate/cursortooltipsettingsstate

Initializes a new instance of the CursorTooltipSettingsState class.

```APIDOC
## CursorTooltipSettingsState()

### Description
Initializes a new instance of the CursorTooltipSettingsState class.

### Method
Constructor

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
N/A (Constructor)

### Response
#### Success Response
Initializes a CursorTooltipSettingsState object.

#### Response Example
```json
{
  "message": "CursorTooltipSettingsState object created successfully."
}
```
```

--------------------------------

### Get Active Guide Color (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.smarttracksettingsstate/guidecolor

Retrieves the current active guide color from the SmartTrackSettingsState. This property returns a Color object representing the guide color.

```csharp
using Rhino.ApplicationSettings;

// Get the current guide color
System.Drawing.Color guideColor = SmartTrackSettingsState.GuideColor;
```

--------------------------------

### BrepFace Class Documentation

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_BrepFace

Documentation for the BrepFace class, including its constructors, properties, and methods.

```APIDOC
## BrepFace Class

### Description
Provides strongly-typed access to brep faces. A Brep face is composed of one surface and trimming curves.

### Inheritance
`Rhino.Runtime.CommonObject` -> `Rhino.Geometry.GeometryBase` -> `Rhino.Geometry.Surface` -> `Rhino.Geometry.SurfaceProxy` -> `BrepFace`

### Namespace
`Rhino.Geometry`

### Constructors
- **CommonObject()**: Allows construction from inheriting classes.
- **CommonObject(SerializationInfo info, StreamingContext context)**: Protected constructor for internal use.
- **GeometryBase(SerializationInfo info, StreamingContext context)**: Protected constructor for internal use.
- **Surface()**: Protected constructor for internal use.
- **Surface(SerializationInfo info, StreamingContext context)**: Protected constructor for internal use.
- **SurfaceProxy()**: Protected constructor for internal use.

### Properties
- **Brep**: Gets the Brep that owns this face.
- **Disposed**: Indicates if this object has been disposed or the document it originally belonged to has been disposed.
- **FaceIndex**: Index of face in Brep.Faces array.
- **HasBrepForm**: Returns True if the Brep.TryConvertBrep function will be successful for this object.
- **HasUserData**: Gets True if this class has any custom information attached to it through UserData.
- **Id** (Guid): Gets or sets the persistent id of this Brep face.
- **IsDeformable**: True if object can be accurately modified with "squishy" transformations.
- **IsDocumentControlled**: If True, this object may not be modified.
- **IsSolid**: Gets a value indicating whether a surface is solid.
- **IsSubDFriendly**: Returns True if the surface is a non-rational, uniform, natural or periodic, cubic NURBS surface.
- **IsSurface**: Gets a value indicating whether the face is synonymous with the underlying surface.
- **IsValid**: Tests an object to see if it is valid.
- **Loops**: Loops in this face.
- **MaterialChannelIndex** (int): This face's rendering material channel index.
- **ObjectType**: Useful for differentiating between basic object types.
- **OrientationIsReversed**: True if face orientation is opposite of natural surface orientation.
- **OuterLoop**: Every face has a single outer loop.
- **PackId** (int): 0 if the pack it is unset, or >0 if the set pack id.
- **PerFaceColor**: If per-face color is "Empty", then this face does not have a custom color.
- **PerformCorruptionTesting**: Used to test ON_Object* pointers for corruption.
- **ProxyBrepSubDFaceId** (Guid): If this face is part of a brep created by SubD.ProxyBrep(), returns the subd component id.
- **SurfaceIndex** (int): Surface index of the 3d surface geometry used by this face or -1.
- **UserData**: List of custom information attached to this class.
- **UserDictionary**: Dictionary of custom information attached to this class.
- **UserStringCount**: Gets the amount of user strings.

### Methods
- **AdjacentEdges()**: Gets the indices of all the BrepEdges that delineate this Face.
- **AdjacentFaces()**: Gets the indices of all the BrepFaces that surround this face.
- **ChangeSurface(Int32 surfaceIndex)**: Replaces the 3d surface geometry used by the face.
- **ClearMaterialChannelIndex()**: Clear this face's rendering material channel index.
- **ClearPackId()**: Sets BrepFace.PackId to 0.
- **ClosestPoint(Point3d testPoint, Double u, Double v)**: Inputs the parameters of the point on the surface that is closest to testPoint.
- **ClosestSide(Double u, Double v)**: Gets the side that is closest, in terms of 3D-distance, to a U and V parameter.
- **ComponentIndex()**: If this geometry is a component in something larger, returns the component index.
- **ConstructConstObject(Object parentObject, Int32 subobjectIndex)**: (Internal use)
```

--------------------------------

### Rhino.Runtime.HostUtils.AutoInstallPlugInFolder

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/autoinstallpluginfolder

Gets the auto install plug-in folder for the machine or the current user.

```APIDOC
## AutoInstallPlugInFolder

### Description
Gets the auto install plug-in folder for machine or current user.

### Method
GET

### Endpoint
/Rhino.Runtime/HostUtils/AutoInstallPlugInFolder

### Parameters
#### Query Parameters
- **currentUser** (Boolean) - Required - True if the query relates to the current user.

### Response
#### Success Response (200)
- **string** (String) - The full path to the relevant auto install plug-in directory.

### Response Example
{
  "example": "C:\\Users\\Username\\AppData\\Roaming\\McNeel\\Rhinoceros\\6.0\\Plug-ins"
}
```

--------------------------------

### FileSettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.filesettings/filesettings

Initializes a new instance of the FileSettings class. This constructor does not require any parameters.

```APIDOC
## FileSettings()

### Description
Initializes a new instance of the FileSettings class.

### Method
Constructor

### Endpoint
N/A (Constructor)

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{
  "example": "FileSettings()"
}
```

### Response
#### Success Response (200)
An initialized FileSettings object.

#### Response Example
```json
{
  "example": "FileSettings object initialized"
}
```
```

--------------------------------

### Get MultiplyTextureType Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/multiplytexturetype

Retrieves the Guid representing the MultiplyTextureType. This is a static read-only property.

```csharp
System.Guid multiplyTextureType = Rhino.Render.ContentUuids.MultiplyTextureType;

```

--------------------------------

### PreviewSceneServer.CppPointer Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewsceneserver/cpppointer

Retrieves the native C++ pointer for the PreviewSceneServer object.

```APIDOC
## PreviewSceneServer.CppPointer Property

### Description
Gets the native C++ pointer for the PreviewSceneServer.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Render/PreviewSceneServer/CppPointer

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
- **CppPointer** (IntPtr) - The native C++ pointer to the PreviewSceneServer object.

#### Response Example
```json
{
  "CppPointer": "0x..."
}
```

### Remarks
Available since Rhino version 6.0.
```

--------------------------------

### Get StandardChannels for Guid - RhinoCommon C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderwindow/standardchannelforguid

This method retrieves the StandardChannels associated with a given Guid. It is part of the Rhino.Render.RenderWindow class and requires a Guid as input. The method returns a StandardChannels object.

```csharp
public static StandardChannels StandardChannelForGuid(  
Guid id  
)
```

--------------------------------

### Instance Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.customrendermeshes.instance/instance

Constructs a new Instance object.

```APIDOC
## Instance()

### Description
Construct a new Instance object.

### Method
public

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (200)
**Instance** (Instance) - A new Instance object.

#### Response Example
N/A

### Remarks
Available since: 8.0
```

--------------------------------

### Get GritBumpTexture Guid in C# - RhinoCommon API

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/gritbumptexture

Retrieves the Guid for the GritBumpTexture. This property is static and part of the Rhino.Render.ContentUuids class. It returns a Guid object representing the texture.

```csharp
public static Guid GritBumpTexture { get; }
```

--------------------------------

### RhinoCommon: Get CrossHatchBumpTexture Guid

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/crosshatchbumptexture

Retrieves the Guid for the CrossHatchBumpTexture. This property is part of the Rhino.Render.ContentUuids class and is available from RhinoCommon version 6.0 onwards. It returns a Guid object.

```csharp
public static Guid CrossHatchBumpTexture { get; }
```

--------------------------------

### ChooseOneObjectSettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.chooseoneobjectsettings/chooseoneobjectsettings

Initializes a new instance of the ChooseOneObjectSettings class.

```APIDOC
## ChooseOneObjectSettings()

### Description
Initializes a new instance of the ChooseOneObjectSettings class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "ChooseOneObjectSettings()"
}
```

### Response
#### Success Response (200)
- **instance** (ChooseOneObjectSettings) - A new instance of the ChooseOneObjectSettings class.

#### Response Example
```json
{
  "example": "// Code to create an instance of ChooseOneObjectSettings"
}
```
```

--------------------------------

### FileSvgReadOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filesvgreadoptions/filesvgreadoptions

Initializes a new instance of the FileSvgReadOptions class. This constructor does not take any arguments.

```APIDOC
## FileSvgReadOptions Constructor

### Description
Initializes a new instance of the FileSvgReadOptions class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "FileSvgReadOptions()"
}
```

### Response
#### Success Response (200)
- **Instance** (FileSvgReadOptions) - A new instance of the FileSvgReadOptions class.

#### Response Example
```json
{
  "example": "// Code to create an instance, no direct JSON output"
}
```
```

--------------------------------

### FileFbxReadOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filefbxreadoptions/filefbxreadoptions

Initializes a new instance of the FileFbxReadOptions class.

```APIDOC
## FileFbxReadOptions()

### Description
Initializes a new instance of the FileFbxReadOptions class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "FileFbxReadOptions()"
}
```

### Response
#### Success Response (Instance)
- **FileFbxReadOptions** (Object) - An initialized instance of the FileFbxReadOptions class.

#### Response Example
```json
{
  "example": "// FileFbxReadOptions object created"
}
```
```

--------------------------------

### Get RealtimeDisplayMode GUID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.realtimedisplaymodeclassinfo/guid

Retrieves the unique implementation GUID for a RealtimeDisplayMode. This property is abstract and must be implemented by derived classes. It is available from Rhino version 6.0 onwards.

```csharp
public abstract Guid GUID {get}
```

--------------------------------

### FileUdo Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileudo/fileudo

Initializes a new instance of the FileUdo class.

```APIDOC
## FileUdo()

### Description
Initializes a new instance of the FileUdo class.

### Method

### Endpoint

### Parameters

### Request Example

### Response
#### Success Response (200)
- **FileUdo** (Object) - An initialized instance of the FileUdo class.

#### Response Example
```json
{
  "example": "An instance of FileUdo"
}
```
```

--------------------------------

### Get GlassMaterialType GUID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/glassmaterialtype

Retrieves the static Guid identifier for the glass material type using the RhinoCommon API. This property does not take any arguments and returns a Guid object representing the material type.

```csharp
public static Guid GlassMaterialType { get; }
```

--------------------------------

### Rhino.Geometry.Brep.CreateFromBox (IEnumerable<Point3d>)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfrombox

Constructs a new Brep from 8 corner points.

```APIDOC
## POST /Rhino.Geometry.Brep/CreateFromBox

### Description
Constructs new brep from 8 corner points.

### Method
POST

### Endpoint
/Rhino.Geometry.Brep/CreateFromBox

### Parameters
#### Request Body
- **corners** (IEnumerable<Point3d>) - Required - 8 points defining the box corners arranged as the vN labels indicate.

### Request Example
```json
{
  "corners": [
    {"x": 0, "y": 0, "z": 0},
    {"x": 1, "y": 0, "z": 0},
    {"x": 1, "y": 1, "z": 0},
    {"x": 0, "y": 1, "z": 0},
    {"x": 0, "y": 0, "z": 1},
    {"x": 1, "y": 0, "z": 1},
    {"x": 1, "y": 1, "z": 1},
    {"x": 0, "y": 1, "z": 1}
  ]
}
```

### Response
#### Success Response (200)
- **brep** (Brep) - A new brep, or null on error.

#### Response Example
```json
{
  "brep": {
    "faces": [...],
    "edges": [...],
    "vertices": [...]
  }
}
```
```

--------------------------------

### Toolbar Id Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.toolbar/id

Gets the unique identifier (Guid) of the toolbar.

```APIDOC
## Toolbar Id Property

### Description
Gets the id of the toolbar.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.UI/Toolbar/Id

### Parameters

### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Id** (Guid) - The unique identifier of the toolbar.

#### Response Example
```json
{
  "Id": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```
```

--------------------------------

### Get Guid by Name (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.namedparameterseventargs/trygetguid

Attempts to retrieve a Guid value associated with a specific name. Returns true if successful and the Guid is output, false otherwise. Requires the Rhino.Runtime namespace.

```csharp
public Boolean TryGetGuid(
  String name,
  out Guid value
)
```

--------------------------------

### GET /Rhino.Render.PostEffects/PostEffectUuids/Glow

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectuuids/glow

Retrieves the unique identifier (Guid) for the Glow post-effect.

```APIDOC
## GET /Rhino.Render.PostEffects/PostEffectUuids/Glow

### Description
Retrieves the Guid that uniquely identifies the Glow post-effect.

### Method
GET

### Endpoint
/Rhino.Render.PostEffects/PostEffectUuids/Glow

### Parameters
None

### Request Body
None

### Response
#### Success Response (200)
- **Glow** (Guid) - The Guid for the Glow post-effect.

#### Response Example
{
  "Glow": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

--------------------------------

### Rhino.Render.PreviewLighting.CppPointer

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewlighting/cpppointer

Retrieves a CppPointer for PreviewLighting.

```APIDOC
## CppPointer Property

### Description
Gets a CppPointer for PreviewLighting.

### Method
GET

### Endpoint
Rhino.Render.PreviewLighting/CppPointer

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **IntPtr** (IntPtr) - The CppPointer for PreviewLighting.

#### Response Example
```json
{
  "CppPointer": "0x..."
}
```

### Remarks
Available since Rhino version 6.0.
```

--------------------------------

### GetActivePlugInVersionFolders (Overload 2)

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_HostUtils

Recurses through auto-install plug-in folders to find active plug-in directories for the current user.

```APIDOC
## GetActivePlugInVersionFolders (Overload 2)

### Description
Recurses through the auto install plug-in folders and returns the directories containing "active" versions of plug-ins.

### Method
N/A (Function signature)

### Endpoint
N/A

### Parameters
* **currentUser** (Boolean) - True to consider only the current user's plug-ins, false otherwise.

### Request Example
None

### Response
* **folders** (Array of String) - An array of directory paths containing active plug-ins.
```

--------------------------------

### Get View ID from RhinoDoc ChangeQueue (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.changequeue.changequeue/viewid

Retrieves the unique identifier (Guid) for a view associated with a Rhino document's change queue. This property is useful for tracking view-specific changes. It returns Guid.Empty if no view is linked to the change queue, such as during preview rendering. This feature is available starting from RhinoCommon version 6.0.

```csharp
public Guid ViewId {get}
```

--------------------------------

### VerifyPreviousVersionLicense Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime

Details on how to verify a previous version license for upgrade purposes.

```APIDOC
## POST /api/verifyPreviousVersionLicense

### Description

When a caller calls GetLicense, ZooClient may call `VerifyPreviousVersionLicense` to ensure `previousVersionLicense` is legitimate and can be used to upgrade the license.

### Method
POST

### Endpoint
`/api/verifyPreviousVersionLicense`

### Parameters

#### Query Parameters

*   **license** (string) - Required - The current license string.
*   **previousVersionLicense** (string) - Required - The license string from a previous version.
*   **errorMessage** (string) - Optional - An error message if verification fails.

#### Request Body

None

### Response

#### Success Response (200)

*   **isValid** (boolean) - True if the previous version license is valid for upgrade, false otherwise.

#### Error Response (e.g., 400, 401, 500)

*   **message** (string) - A descriptive error message.

### Request Example

```json
{
  "license": "CURRENT_LICENSE_STRING",
  "previousVersionLicense": "PREVIOUS_LICENSE_STRING"
}
```

### Response Example (Success)

```json
{
  "isValid": true
}
```
```

--------------------------------

### Get PerturbingTextureType Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/perturbingtexturetype

Retrieves the Guid for the PerturbingTextureType. This property is available since Rhino version 6.0 and is part of the Rhino.Render.ContentUuids class.

```csharp
public static Guid PerturbingTextureType {get}
```

--------------------------------

### Rhino.PlugIns.PlugIn.NameFromPath

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/namefrompath

Gets a plug-in name for an installed plug-in given the path to that plug-in.

```APIDOC
## Rhino.PlugIns.PlugIn.NameFromPath

### Description
Gets a plug-in name for an installed plug-in given the path to that plug-in.

### Method
`public static String NameFromPath(String pluginPath)`

### Endpoint
N/A (This is a static method within the RhinoCommon library, not a web endpoint).

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
string pluginName = Rhino.PlugIns.PlugIn.NameFromPath("C:\\Path\\To\\MyPlugin.rhp");
```

### Response
#### Success Response
- **String** - The plug-in name.

#### Response Example
```json
{
  "pluginName": "MyAwesomePlugin"
}
```

### Availability
Available since: 5.0
```

--------------------------------

### Brep.CreateFromSurface

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfromsurface

Constructs a Brep from a surface. The resulting Brep has an outer boundary made from four trims. The trims are ordered so that they run along the south, east, north, and then west side of the surface's parameter space.

```APIDOC
## Brep.CreateFromSurface

### Description
Constructs a Brep from a surface. The resulting Brep has an outer boundary made from four trims. The trims are ordered so that they run along the south, east, north, and then west side of the surface's parameter space.

### Method
`public static Brep CreateFromSurface(Surface surface)`

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Brep** (Brep) - Resulting brep or None on failure.

#### Response Example
```json
{
  "result": "Brep object or null"
}
```

### Availability
Available since: 5.0
```

--------------------------------

### Get Rhino Installation Folder Path

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Returns the full path to the Rhino installation folder. This is useful for accessing installed files, libraries, or other resources located within the Rhino program directory.

```python
import rhinoscriptsyntax as rs

print(rs.InstallFolder())
```

--------------------------------

### Rhino.Render.PreviewBackground.CppPointer

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewbackground/cpppointer

Retrieves a CppPointer for the PreviewLighting.

```APIDOC
## Rhino.Render.PreviewBackground.CppPointer

### Description
Retrieves a CppPointer for the PreviewLighting.

### Method
GET

### Endpoint
/Rhino/Render/PreviewBackground/CppPointer

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **CppPointer** (IntPtr) - A pointer to the Cpp representation of PreviewLighting.

#### Response Example
```json
{
  "CppPointer": "0x12345678"
}
```
```

--------------------------------

### Get Render Channels GUIDs (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderwindow/getrequestedrenderchannels

Retrieves an array of Guids that represent the channels requested by the post-effect pipeline for a RenderWindow. This method returns a Guid[] and is available since version 7.0.

```csharp
public Guid[] GetRequestedRenderChannels()
```

--------------------------------

### AddLayout Example (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/examples/addlayout

This C# example demonstrates how to generate a layout with a single detail view that zooms to a list of objects using the RhinoCommon API.

```APIDOC
## AddLayout Example

### Description
Generates a layout with a single detail view, setting it to zoom extents and then locking the projection. The detail is scaled according to the document's units.

### Method
*Not applicable, this is a code example*

### Endpoint
*Not applicable, this is a code example*

### Parameters
* **doc** (Rhino.RhinoDoc) - The current Rhino document.

### Request Example
```csharp
partial class Examples
{
  /// <summary>
  /// Generate a layout with a single detail view that zooms to a list of objects
  /// </summary>
  /// <param name="doc"></param>
  /// <returns></returns>
  public static Rhino.Commands.Result AddLayout(Rhino.RhinoDoc doc)
  {
    doc.PageUnitSystem = Rhino.UnitSystem.Millimeters;
    var page_views = doc.Views.GetPageViews();
    int page_number = (page_views==null) ? 1 : page_views.Length + 1;
    var pageview = doc.Views.AddPageView(string.Format("A0_{0}",page_number), 1189, 841);
    if( pageview!=null )
    {
      Rhino.Geometry.Point2d top_left = new Rhino.Geometry.Point2d(20,821);
      Rhino.Geometry.Point2d bottom_right = new Rhino.Geometry.Point2d(1169, 20);
      var detail = pageview.AddDetailView("ModelView", top_left, bottom_right, Rhino.Display.DefinedViewportProjection.Top);
      if (detail != null)
      {
        pageview.SetActiveDetail(detail.Id);
        detail.Viewport.ZoomExtents();
        detail.DetailGeometry.IsProjectionLocked = true;
        detail.DetailGeometry.SetScale(1, doc.ModelUnitSystem, 10, doc.PageUnitSystem);
        // Commit changes tells the document to replace the document's detail object
        // with the modified one that we just adjusted
        detail.CommitChanges();
      }
      pageview.SetPageAsActive();
      doc.Views.ActiveView = pageview;
      doc.Views.Redraw();
      return Rhino.Commands.Result.Success;
    }
    return Rhino.Commands.Result.Failure;
  }
}
```

### Response
* **Rhino.Commands.Result** - Returns Result.Success if the layout is generated successfully, otherwise Result.Failure.
```

--------------------------------

### Line.FromY Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.line/fromy

Gets or sets the Y coordinate of the line's starting point.

```APIDOC
## Line.FromY Property

### Description
Gets or sets the Y coordinate of the line From point.

### Method
`get` or `set`

### Endpoint
Rhino.Geometry.Line.FromY

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "(This is a property, not an endpoint that takes a request body)"
}
```

### Response
#### Success Response (200)
- **Y Coordinate** (double) - The Y coordinate of the line's starting point.

#### Response Example
```json
{
  "example": 10.5 
}
```

### Remarks
Available since RhinoCommon version 5.0.
```

--------------------------------

### Get WireframeCurvesRGBA Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectuuids/wireframecurvesrgba

Retrieves the Guid for the WireframeCurvesRGBA post-effect. This static property returns a Guid value representing the effect. It is available in RhinoCommon API version 8.13 and later.

```csharp
public static Guid WireframeCurvesRGBA {get}
```

--------------------------------

### GetActivePlugInVersionFolders (Overload 1)

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_HostUtils

Recurses through auto-install plug-in folders to find active plug-in directories.

```APIDOC
## GetActivePlugInVersionFolders (Overload 1)

### Description
Recurses through the auto install plug-in folders and returns the directories containing "active" versions of plug-ins.

### Method
N/A (Function signature)

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
* **folders** (Array of String) - An array of directory paths containing active plug-ins.
```

--------------------------------

### Get FBmTextureType GUID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/fbmtexturetype

Retrieves the static Guid representing the FBmTextureType. This property is part of the Rhino.Render.ContentUuids class and is available in RhinoCommon version 6.0 and later. It returns a Guid object.

```csharp
public static Guid FBmTextureType {get}
```

--------------------------------

### GeneralSettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.generalsettings/generalsettings

Initializes a new instance of the GeneralSettings class.

```APIDOC
## GeneralSettings()

### Description
Initializes a new instance of the GeneralSettings class.

### Method

### Endpoint

### Parameters

#### Path Parameters

#### Query Parameters

#### Request Body

### Request Example

### Response
#### Success Response (200)

#### Response Example

```

--------------------------------

### Get Render Settings Section GUIDs (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.renderplugin/getrendersettingssections

This C# function retrieves a list of Guids for the render settings pages that should be displayed. It returns a List<Guid> containing the IDs of the render settings sections.

```csharp
public List<Guid> GetRenderSettingsSections()
{
    // Implementation returns a list of Guids for render settings pages.
    return new List<Guid>();
}
```

--------------------------------

### RenderWindow.ChannelGPU.CopyTo

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderwindow.channelgpu/copyto

Copies the current channel to a specified 'CPU' channel.

```APIDOC
## POST /Rhino.Render/RenderWindow.ChannelGPU/CopyTo

### Description
Copies the channel to a 'CPU' channel.

### Method
POST

### Endpoint
/Rhino.Render/RenderWindow.ChannelGPU/CopyTo

### Parameters
#### Request Body
- **channel** (Channel) - Required - The channel to copy to.

### Request Example
{
  "channel": "CPU_CHANNEL_IDENTIFIER"
}

### Response
#### Success Response (200)
- **Void** - This method does not return a value.

#### Response Example
(No response body for Void return type)
```

--------------------------------

### Get RaytracedId Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaymodedescription/raytracedid

Retrieves the static Guid identifier for the Raytraced display mode using the RhinoCommon API. This property is part of the DisplayModeDescription class and returns a Guid value.

```csharp
System.Guid id = Rhino.Display.DisplayModeDescription.RaytracedId;
```

--------------------------------

### RenderPipeline.OnRenderBegin

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderpipeline/onrenderbegin

This method is called by the framework when it is time to start rendering. The render window will be created at this point, and it is safe to start the rendering process.

```APIDOC
## protected abstract Boolean OnRenderBegin()

### Description
Called by the framework when it is time to start rendering. The render window will be created at this point and it is safe to start.

### Method
protected abstract

### Endpoint
N/A

### Parameters
None

### Request Example
N/A

### Response
#### Success Response
- **Boolean** (Boolean) - Returns true if rendering can begin, false otherwise.

#### Response Example
```
true
```
```

--------------------------------

### Get Hud Start Time (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.realtimedisplaymode/hudstarttime

The HudStartTime method in Rhino.Render.RealtimeDisplayMode returns the start time of the HUD. This method is virtual and returns a DateTime object. It has been available since RhinoCommon version 6.0.

```csharp
public virtual System.DateTime HudStartTime()

```

--------------------------------

### FileX3dvWriteOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filex3dvwriteoptions/filex3dvwriteoptions

Initializes a new instance of the FileX3dvWriteOptions class. This constructor does not take any arguments.

```APIDOC
## FileX3dvWriteOptions()

### Description
Initializes a new instance of the FileX3dvWriteOptions class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "message": "This is a constructor, no request body needed."
}
```

### Response
#### Success Response (Instance)
- **Instance** (FileX3dvWriteOptions) - A new instance of the FileX3dvWriteOptions class.

#### Response Example
```json
{
  "message": "FileX3dvWriteOptions instance created successfully."
}
```
```

--------------------------------

### Get Rhino Installation Type (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/installationtype

Retrieves the installation type of the Rhino product. This property is read-only and returns an enum value of type Installation. It is available from version 5.0 onwards.

```csharp
using Rhino.RhinoApp;

// Get the installation type
Installation installationType = RhinoApp.InstallationType;

// You can then check the value of installationType
if (installationType == Installation.Retail)
{
    // Handle retail installation
}
else if (installationType == Installation.Evaluation)
{
    // Handle evaluation installation
}
// etc.
```

--------------------------------

### AnimationProperties.StartMonth

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.animationproperties/startmonth

Gets or sets the start month for seasonal/one day sun animation in the range 1 to 12.

```APIDOC
## AnimationProperties.StartMonth

### Description
Gets or sets the start month for seasonal/one day sun animation in the range 1 to 12.

### Method
GET | SET

### Endpoint
Rhino.DocObjects/AnimationProperties/StartMonth

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (this is a property)

### Request Example
```json
{
  "startMonth": 7 
}
```

### Response
#### Success Response (200)
- **startMonth** (int) - The start month for sun animation (1-12).

#### Response Example
```json
{
  "startMonth": 7 
}
```
```

--------------------------------

### FileVdaWriteOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filevdawriteoptions/filevdawriteoptions

Initializes a new instance of the FileVdaWriteOptions class.

```APIDOC
## FileVdaWriteOptions()

### Description
Initializes a new instance of the FileVdaWriteOptions class.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.FileIO/FileVdaWriteOptions/FileVdaWriteOptions

### Parameters
None

### Request Example
```json
{
  "example": "No request body needed for constructor"
}
```

### Response
#### Success Response (200)
- **instance** (FileVdaWriteOptions) - A new instance of the FileVdaWriteOptions class.

#### Response Example
```json
{
  "example": "FileVdaWriteOptions instance created"
}
```
```

--------------------------------

### Rhino.FileIO.FileSwReadOptions.ToDictionary

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileswreadoptions/todictionary

Creates a dictionary of file import options.

```APIDOC
## Rhino.FileIO.FileSwReadOptions.ToDictionary

### Description
Creates a dictionary of these options. This dictionary can be passed to the RhinoDoc.Import function.

### Method
public ArchivableDictionary  ToDictionary()

### Endpoint
N/A (This is a C# method, not an HTTP endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (200)
- **ArchivableDictionary** (Type) - A dictionary containing the file read options.

#### Response Example
```json
{
  "example": "ArchivableDictionary"
}
```

### Remarks
Available since: 8.0
```

--------------------------------

### Get Curve Start Point

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

This code retrieves the starting point of a curve object. It can optionally handle polycurves by specifying a segment index, and can also set a new start point if provided. The function returns the 3D starting point of the curve.

```python
import rhinoscriptsyntax as rs

object = rs.GetObject("Select a curve")
if rs.IsCurve(object):
    point = rs.CurveStartPoint(object)
    rs.AddPoint(point)
```

--------------------------------

### Rhino.Geometry.Extrusion.PathStart

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.extrusion/pathstart

Gets the start point of the extrusion path. This property is available since version 5.0.

```APIDOC
## GET /Rhino.Geometry/Extrusion/PathStart

### Description
Gets the start point of the extrusion path.

### Method
GET

### Endpoint
/Rhino.Geometry/Extrusion/PathStart

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **PathStart** (Point3d) - The starting point of the extrusion path.

#### Response Example
```json
{
  "PathStart": {
    "X": 0.0,
    "Y": 0.0,
    "Z": 0.0
  }
}
```
```

--------------------------------

### Initialize RhinoCommon Components (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/initializerhinocommon

Ensures all static RhinoCommon components are set up correctly. This is typically handled automatically when a plug-in is loaded and subsequent calls are ignored. It returns void.

```csharp
public static Void InitializeRhinoCommon()
```

--------------------------------

### FileUdoWriteOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileudowriteoptions/fileudowriteoptions

Initializes a new instance of the FileUdoWriteOptions class.

```APIDOC
## FileUdoWriteOptions Constructor

### Description
Initializes a new instance of the FileUdoWriteOptions class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "FileUdoWriteOptions()"
}
```

### Response
#### Success Response (200)
Initializes a new FileUdoWriteOptions object.

#### Response Example
```json
{
  "example": "FileUdoWriteOptions instance"
}
```
```

--------------------------------

### FileFbxWriteOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filefbxwriteoptions/filefbxwriteoptions

Initializes a new instance of the FileFbxWriteOptions class.

```APIDOC
## FileFbxWriteOptions()

### Description
Initializes a new instance of the FileFbxWriteOptions class.

### Method
Constructor

### Endpoint
Rhino.FileIO.FileFbxWriteOptions()

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{
  "example": "FileFbxWriteOptions()"
}
```

### Response
#### Success Response (200)
An initialized instance of the FileFbxWriteOptions class.

#### Response Example
```json
{
  "example": "FileFbxWriteOptions object"
}
```
```

--------------------------------

### Get Rhino Materials Panel GUID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/materials

Retrieves the unique identifier (GUID) for the Rhino Materials panel. This property is part of the Rhino.UI.PanelIds class and is available since Rhino 5.0. It returns a Guid object.

```csharp
public static Guid Materials { get; }
```

--------------------------------

### Rhino.Geometry.Brep.CreateFromBox (BoundingBox)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfrombox

Constructs a new Brep that matches a given BoundingBox.

```APIDOC
## POST /Rhino.Geometry.Brep/CreateFromBox

### Description
Constructs new brep that matches a bounding box.

### Method
POST

### Endpoint
/Rhino.Geometry.Brep/CreateFromBox

### Parameters
#### Request Body
- **box** (BoundingBox) - Required - A box to use for creation.

### Request Example
```json
{
  "box": {
    "min": {"x": 0, "y": 0, "z": 0},
    "max": {"x": 1, "y": 1, "z": 1}
  }
}
```

### Response
#### Success Response (200)
- **brep** (Brep) - A new brep; or null on failure.

#### Response Example
```json
{
  "brep": {
    "faces": [...],
    "edges": [...],
    "vertices": [...]
  }
}
```
```

--------------------------------

### Get Plugin Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.lightmanagersupport/pluginid

This snippet demonstrates how to retrieve the unique identifier (Guid) of a plugin using the PluginId method within the RhinoCommon API. It returns a Guid object representing the plugin.

```csharp
public abstract Guid PluginId()
{
  // Returns the Guid of the plugin
}
```

--------------------------------

### Utilities Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.utilities/utilities

Initializes a new instance of the Utilities class.

```APIDOC
## Utilities Constructor

### Description
Initializes a new instance of the Utilities class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "Utilities()"
}
```

### Response
#### Success Response (200)
This is a constructor, it does not return a value in the traditional sense.

#### Response Example
```json
{
  "example": "Instance of Utilities created."
}
```
```

--------------------------------

### Get BasicMaterialCCI Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/basicmaterialcci

Retrieves the static Guid for BasicMaterialCCI from the Rhino.Render.ContentUuids class. This property is read-only and requires no input parameters. It returns a Guid representing the unique identifier for basic materials.

```csharp
public static Guid BasicMaterialCCI {get}
```

--------------------------------

### FileXaml Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filexaml/filexaml

Initializes a new instance of the FileXaml class.

```APIDOC
## FileXaml()

### Description
Initializes a new instance of the FileXaml class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
FileXaml()
```

### Response
#### Success Response (200)
An initialized FileXaml object.

#### Response Example
```json
{
  "instance": "FileXaml"
}
```
```

--------------------------------

### Get EdgeSoftening Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.customrendermeshes.meshproviderids/edgesoftening

Retrieves the static Guid value for EdgeSoftening from the MeshProviderIds class. This property is available in Rhino 8.0 and later.

```csharp
public static Guid EdgeSoftening {get}
```

--------------------------------

### Untitled

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_PersistentSettings

No description

--------------------------------

### BoundingBox.ToBrep()

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.boundingbox/tobrep

Constructs a Brep representation of this bounding box. Returns a Brep if successful, otherwise null.

```APIDOC
## BoundingBox.ToBrep()

### Description
Constructs a Brep representation of this bounding box.

### Method
Public

### Endpoint
N/A (This is a method within a class)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Brep)
- **Brep** (Type: Brep) - A Brep representation of the bounding box.

#### Error Response (null)
- **null** (Type: Brep) - If the operation is not successful.

### Response Example
```json
{
  "example": "Brep object or null"
}
```

### Available since
5.0
```

--------------------------------

### Get Arc Start Point in C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.arc/startpoint

Retrieves the starting point of an arc. This property is read-only and returns a Point3d object representing the coordinates.

```csharp
public Point3d StartPoint { get; }
```

--------------------------------

### Access SpeckleBumpTexture Guid in RhinoCommon

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/specklebumptexture

Retrieves the Guid identifier for the SpeckleBumpTexture. This property is part of the Rhino.Render.ContentUuids class and is available starting from version 6.0.

```csharp
public static Guid SpeckleBumpTexture {get}
```

--------------------------------

### FileGtsWriteOptions.ToDictionary

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filegtswriteoptions/todictionary

Creates a dictionary of options that can be passed to the RhinoDoc.Export function.

```APIDOC
## FileGtsWriteOptions.ToDictionary

### Description
Creates a dictionary of these options. This dictionary can be passed to the RhinoDoc.Export function.

### Method
public ArchivableDictionary ToDictionary()

### Endpoint
Rhino.FileIO/FileGtsWriteOptions/ToDictionary

### Parameters
This method does not take any parameters.

### Request Example
```json
{
  "example": "No request body for this method."
}
```

### Response
#### Success Response (200)
- **ArchivableDictionary** (Type) - A dictionary containing the export options.

#### Response Example
```json
{
  "example": "ArchivableDictionary object representing export options."
}
```
```

--------------------------------

### Get Guid with Default Value (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.collections.archivabledictionary/getguid

Retrieves a Guid value associated with a given key. If the key does not exist or was not set using Set(string key, Guid value), it returns the provided default Guid value. This method is available from version 5.0.

```csharp
public Guid GetGuid(
  String key,
  Guid defaultValue
)
```

--------------------------------

### RenderMeshProviderProgress Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.customrendermeshes.rendermeshproviderprogress/rendermeshproviderprogress

Initializes a new instance of the RenderMeshProviderProgress class.

```APIDOC
## RenderMeshProviderProgress()

### Description
Initializes a new instance of the RenderMeshProviderProgress class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "RenderMeshProviderProgress()"
}
```

### Response
#### Success Response (N/A)
This is a constructor and does not return a value in the traditional sense.

#### Response Example
```json
{
  "example": "Instance of RenderMeshProviderProgress created."
}
```
```

--------------------------------

### FileSvg() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filesvg/filesvg

Initializes a new instance of the FileSvg class.

```APIDOC
## FileSvg()

### Description
Initializes a new instance of the FileSvg class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "FileSvg()"
}
```

### Response
#### Success Response (Instance)
- **FileSvg** (Object) - An initialized instance of the FileSvg class.

#### Response Example
```json
{
  "example": "new FileSvg()"
}
```
```

--------------------------------

### Get Rhino 5 ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/rhino5id

Retrieves the static Guid that uniquely identifies Rhino 5. This property is read-only and returns a Guid object.

```csharp
System.Guid rhino5Guid = Rhino.RhinoApp.Rhino5Id;
// The rhino5Guid variable now holds the ID for Rhino 5.
```

--------------------------------

### Get WoodBumpTexture Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/woodbumptexture

Retrieves the static Guid representing the WoodBumpTexture. This property is read-only and available in RhinoCommon version 6.0 and later.

```csharp
public static Guid WoodBumpTexture {get}
```

--------------------------------

### Brep.CreateFromCone Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfromcone

Constructs a Brep representation of the cone with a single face for the cone, an edge along the cone seam, and vertices at the base and apex ends of this seam edge. The optional cap is a single face with one circular edge starting and ending at the base vertex.

```APIDOC
## Brep.CreateFromCone Method

### Description
Constructs a Brep representation of the cone with a single face for the cone, an edge along the cone seam, and vertices at the base and apex ends of this seam edge. The optional cap is a single face with one circular edge starting and ending at the base vertex.

### Method
`public static Brep CreateFromCone(Cone cone, Boolean capBottom)`

### Endpoint
N/A (This is a static method within a class)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "cone": { /* Cone object details */ },
  "capBottom": true
}
```

### Response
#### Success Response (Brep)
- **Brep** (Brep) - A Brep representation of the cone if successful.

#### Error Response
- **None** - Returns None on error.

#### Response Example
```json
{
  "Brep": { /* Brep object details */ }
}
```

### Availability
- **Available since:** 5.0
```

--------------------------------

### Get ProjectionChangerTextureType Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/projectionchangertexturetype

Retrieves the Guid for the ProjectionChangerTextureType. This static property belongs to the Rhino.Render.ContentUuids class and is available from RhinoCommon version 6.0 onwards.

```csharp
public static Guid ProjectionChangerTextureType {get}
```

--------------------------------

### Get MaskTextureType Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/masktexturetype

Retrieves the static Guid value for MaskTextureType from the Rhino.Render.ContentUuids class. This property is read-only and indicates the type identifier for mask textures.

```csharp
public static Guid MaskTextureType { get; }
```

--------------------------------

### PlugInId Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.materialref/pluginid

Gets or sets the GUID that identifies a rendering plug-in.

```APIDOC
## Rhino.DocObjects.MaterialRef.PlugInId

### Description
Identifies a rendering plug-in.

### Method
`get | set`

### Endpoint
N/A (Property)

### Parameters
None

### Request Example
```json
{
  "example": "N/A"
}
```

### Response
#### Success Response (200)
- **Type**: Guid
- **Available since**: 5.10

#### Response Example
```json
{
  "example": "A unique identifier for the rendering plug-in."
}
```
```

--------------------------------

### Get DoubleSidedMaterialType Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/doublesidedmaterialtype

Retrieves the static Guid representing the DoubleSidedMaterialType. This property is part of the Rhino.Render.ContentUuids class and is available from Rhino version 7.0 onwards.

```csharp
System.Guid materialType = Rhino.Render.ContentUuids.DoubleSidedMaterialType;

```

--------------------------------

### SupportOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.supportoptions/supportoptions

Initializes a new instance of the SupportOptions class.

```APIDOC
## SupportOptions Constructor

### Description
Initializes a new instance of the SupportOptions class.

### Method
* (Constructor)

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "SupportOptions()"
}
```

### Response
#### Success Response (Instance)
- **SupportOptions** (Object) - An initialized instance of the SupportOptions class.

#### Response Example
```json
{
  "example": "// No direct JSON representation for constructor output, but an instance is created."
}
```
```

--------------------------------

### LicenseLease Constructor (Full Details)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.licenselease/licenselease

Initializes a new instance of the LicenseLease class with comprehensive product and lease details. This constructor is available since version 6.4.

```APIDOC
## LicenseLease(string productId, string groupName, string groupId, string userName, string userId, string productTitle, string productVersion, string productEdition, string leaseId, DateTime iat, DateTime exp, DateTime renewable_until)

### Description
Initializes a new instance of the LicenseLease class with comprehensive product and lease details, including a renewable until date.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
*   **productId** (string) - Required - The unique identifier for the product.
*   **groupName** (string) - Required - The name of the user group.
*   **groupId** (string) - Required - The unique identifier for the user group.
*   **userName** (string) - Required - The name of the user.
*   **userId** (string) - Required - The unique identifier for the user.
*   **productTitle** (string) - Required - The title of the product.
*   **productVersion** (string) - Required - The version of the product.
*   **productEdition** (string) - Required - The edition of the product.
*   **leaseId** (string) - Required - The unique identifier for the lease.
*   **iat** (DateTime) - Required - The "issued at" time of the lease.
*   **exp** (DateTime) - Required - The expiration time of the lease.
*   **renewable_until** (DateTime) - Required - The date until which the lease can be renewed.

### Request Example
None (Constructor)

### Response
#### Success Response (N/A)
N/A (Constructor)

#### Response Example
None (Constructor)

### Remarks
Available since: 6.4
```

--------------------------------

### Get DotBumpTexture Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/dotbumptexture

Retrieves the static Guid representing the DotBumpTexture. This property is part of the Rhino.Render.ContentUuids class and is available since Rhino version 6.0.

```csharp
public static Guid DotBumpTexture {get}
```

--------------------------------

### ParticleSystem Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.particlesystem/particlesystem

Initializes a new instance of the ParticleSystem class.

```APIDOC
## ParticleSystem()

### Description
Initializes a new instance of the ParticleSystem class.

### Method
CONSTRUCTOR

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "ParticleSystem()"
}
```

### Response
#### Success Response (200)
- **ParticleSystem** (ParticleSystem) - An initialized ParticleSystem object.

#### Response Example
```json
{
  "example": "ParticleSystem object initialized"
}
```
```

--------------------------------

### GuidField Value Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.fields.guidfield/value

Provides information about getting or setting the Guid value for a GuidField.

```APIDOC
## GuidField Value Property

### Description
Gets or sets the field value. This property allows for retrieval or modification of the Guid associated with the field.

### Method
Get/Set

### Endpoint
Rhino.Render.Fields.GuidField.Value

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "Not applicable for property access"
}
```

### Response
#### Success Response (200)
- **Value** (Guid) - The Guid value of the field.

#### Response Example
```json
{
  "example": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

### Remarks
Available since version 5.1 of the RhinoCommon API.
```

--------------------------------

### Triangle3d.AltitudeA

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.triangle3d/altitudea

Gets the altitude line starting at corner A of a Triangle3d object.

```APIDOC
## Triangle3d.AltitudeA

### Description
Gets the altitude line starting at corner A.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Geometry/Triangle3d/AltitudeA

### Parameters

### Request Body

### Request Example

### Response
#### Success Response (200)
- **Returns** (Line) - The altitude line starting at corner A.

#### Response Example
{
  "example": "{\"from\": {\"x\": 0.0, \"y\": 0.0, \"z\": 0.0}, \"to\": {\"x\": 1.0, \"y\": 1.0, \"z\": 1.0}}"
}
```

--------------------------------

### SimpleArrayGuidPointer Class

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_InteropWrappers_SimpleArrayGuidPointer

Documentation for the SimpleArrayGuidPointer class, including its constructors, properties, and methods.

```APIDOC
## SimpleArrayGuidPointer Class

Wrapper for ON_SimpleArray. If you are not writing C++ code then this class is not for you.

### Namespace
Rhino.Runtime.InteropWrappers

### Constructors

#### SimpleArrayGuidPointer()

Initializes a new `SimpleArrayGuidPointer` class.

### Properties

#### Count

Gets the amount of elements in this array.

Type: `int`

#### Item

Get the Guid at index.

Parameters:
- **index** (int) - The index of the Guid to retrieve.

Returns: `Guid`

### Methods

#### ConstPointer()

Gets the constant (immutable) pointer of this array.

Returns: `IntPtr` (a pointer to the unmanaged array)

#### Dispose()

Actively reclaims unmanaged resources that this instance uses.

#### NonConstPointer()

Gets the non-constant pointer (for modification) of this array.

Returns: `IntPtr` (a pointer to the unmanaged array)

#### ToArray()

Returns the managed counterpart of the unmanaged array.

Returns: `Guid[]` (a managed array of Guids)

```

--------------------------------

### LicenseLease Constructor (Full Parameters)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.licenselease/licenselease

Initializes a new instance of the LicenseLease class with a comprehensive set of parameters including product details, user information, lease identifiers, and expiration times. This constructor is available since version 6.4.

```csharp
public LicenseLease(
string productId,
string groupName,
string groupId,
string userName,
string userId,
string productTitle,
string productVersion,
string productEdition,
string leaseId,
DateTime iat,
DateTime exp,
DateTime renewable_until
)
```

--------------------------------

### Rhino.PlugIns.PlugIn.InstalledPlugInCount

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/installedplugincount

Gets the number of installed Rhino plug-ins.

```APIDOC
## Rhino.PlugIns.PlugIn.InstalledPlugInCount

### Description
Returns the number of installed Rhino plug-ins.

### Method
GET (Property Access)

### Endpoint
Not applicable (this is a static property).

### Parameters
None

### Request Example
```csharp
int count = Rhino.PlugIns.PlugIn.InstalledPlugInCount;
```

### Response
#### Success Response (200)
- **count** (int) - The number of installed Rhino plug-ins.

#### Response Example
```json
{
  "count": 15
}
```
```

--------------------------------

### LicenseLease Constructor (Basic Parameters)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.licenselease/licenselease

Initializes a new instance of the LicenseLease class with essential parameters, including product details, user information, lease identifiers, and issue/expiration times. This constructor is available since version 6.0.

```csharp
public LicenseLease(
string productId,
string groupName,
string groupId,
string userName,
string userId,
string productTitle,
string productVersion,
string productEdition,
string leaseId,
DateTime iat,
DateTime exp
)
```

--------------------------------

### Get V8 Blend Material Type Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/v8blendmaterialtype

Retrieves the static Guid representing the V8 Blend material type. This property is part of the Rhino.Render.ContentUuids class and is available in Rhino 8.0 and later. It returns a Guid value.

```csharp
public static Guid V8BlendMaterialType { get; }
```

--------------------------------

### Get Plug-in ID from Filename (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/idfromfilename

This C# code demonstrates how to use the IdFromFileName method to get a plug-in's Guid from its filename. It takes a string representing the plug-in's filename as input and returns a Guid. If the plug-in is not found, it returns Guid.Empty. This method is available from version 8.15 onwards.

```csharp
using System;
using Rhino.PlugIns;

public class Example
{
    public static void GetPluginId(string filename)
    {
        Guid pluginId = PlugIn.IdFromFileName(filename);
        if (pluginId != Guid.Empty)
        {
            Console.WriteLine($"Plug-in ID for {filename}: {pluginId}");
        }
        else
        {
            Console.WriteLine($"Could not find plug-in with filename: {filename}");
        }
    }
}
```

--------------------------------

### Get Texture2DCheckerTextureType Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/texture2dcheckertexturetype

Retrieves the Guid that identifies the 2D checker texture type within Rhino. This property is static and part of the Rhino.Render.ContentUuids class. It returns a Guid and has been available since version 6.0.

```csharp
public static Guid Texture2DCheckerTextureType {get}
```

--------------------------------

### RhinoGet Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.rhinoget/rhinoget

Initializes a new instance of the RhinoGet class.

```APIDOC
## RhinoGet Constructor

### Description
Initializes a new instance of the RhinoGet class.

### Method
constructor

### Endpoint
N/A (Class constructor)

### Parameters
This constructor does not take any parameters.

### Request Example
```javascript
// No request body for constructor
```

### Response
#### Success Response (Instance)
- **RhinoGet** (object) - An initialized instance of the RhinoGet class.

#### Response Example
```json
{
  "message": "RhinoGet instance created successfully"
}
```
```

--------------------------------

### SetupDisplayMaterial with minimal parameters | RhinoCommon C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaypipeline/setupdisplaymaterial

Sets up a display material using only the active document and a Rhino object. This overload is available since version 8.0 and returns a DisplayMaterial if successful, otherwise None.

```csharp
public DisplayMaterial SetupDisplayMaterial(
  RhinoDoc doc,
  RhinoObject rhinoObject
)
```

--------------------------------

### Get SingleColorTextureType Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/singlecolortexturetype

Retrieves the static Guid value for the SingleColorTextureType property from the Rhino.Render.ContentUuids class. This property represents a specific texture type within the Rhino rendering system. It does not take any parameters and returns a Guid.

```csharp
public static Guid SingleColorTextureType {get}
```

--------------------------------

### Rhino.PlugIns.PlugIn.IdFromPath

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/idfrompath

Retrieves the GUID of an installed Rhino plug-in given the full path to its DLL file.

```APIDOC
## Rhino.PlugIns.PlugIn.IdFromPath

### Description
Gets the id of an installed plug-in giving the plug-in's file path.

### Method
Public Static Method

### Endpoint
N/A (This is a static method, not an HTTP endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
System.Guid pluginId = Rhino.PlugIns.PlugIn.IdFromPath("C:\\Program Files\\Rhinoceros 5\\Plug-ins\\MyPlugin.rhp");
```

### Response
#### Success Response (200)
- **Guid** (System.Guid) - The unique identifier of the plug-in if found.

#### Response Example
```json
{
  "guid": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

### Error Handling
- If the pluginPath is invalid or the plug-in is not found, the method may throw an exception or return a default Guid value (e.g., Guid.Empty).
```

--------------------------------

### Torus.ToBrep Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.torus/tobrep

Converts this torus to a Brep. This is synonymous with calling Brep.CreateFromTorus.

```APIDOC
## Torus.ToBrep

### Description
Converts this torus to a Brep. This is synonymous with calling **Brep.CreateFromTorus**.

### Method
`public Brep ToBrep()`

### Endpoint
N/A (This is a class method, not an HTTP endpoint)

### Parameters
None

### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Brep** (Brep) - A Brep representation of this torus, or None on error.

#### Response Example
```json
{
  "brep": "..."
}
```

### Remarks
Available since: 8.1
```

--------------------------------

### Get Rhino Environment Panel GUID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/environment

Retrieves the unique identifier (Guid) for the Rhino Environment panel. This property is part of the Rhino.UI.PanelIds class and is accessible directly.

```csharp
public static Guid Environment { get; }
```

--------------------------------

### Get ToneMapper_Filmic GUID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectuuids/tonemapper_filmic

Retrieves the static Guid for the ToneMapper_Filmic post-effect. This property is part of the Rhino.Render.PostEffects.PostEffectUuids class and is available since Rhino version 8.13.

```csharp
public static Guid ToneMapper_Filmic { get; }
```

--------------------------------

### Rhino.Runtime.HostUtils.CreateCommands (Void)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/createcommands

Parses a plugin and creates all the commands defined therein. This overload returns void.

```APIDOC
## CreateCommands (Void)

### Description
Parses a plugin and create all the commands defined therein.

### Method
`public static Void CreateCommands(PlugIn plugin)`

### Endpoint
N/A (This is a static method, not an HTTP endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "plugin": "<PlugIn object>"
}
```

### Response
#### Success Response (200)
Void return type, no specific response body.

#### Response Example
None
```

--------------------------------

### Check if Installation is Beta (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/isinstallationbeta

Determines if the provided installation license type is a beta license. Beta licenses allow full product usage during the pre-release development phase. This method takes an 'Installation' object as input and returns a boolean value.

```csharp
public static Boolean IsInstallationBeta(Installation licenseType)
```

--------------------------------

### Get PerlinMarbleTextureType Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/perlinmarbletexturetype

This code snippet demonstrates how to access the static Guid property PerlinMarbleTextureType from the Rhino.Render.ContentUuids class. This Guid identifies the Perlin Marble texture type. No specific dependencies are mentioned beyond the RhinoCommon library.

```csharp
using System;
using Rhino.Render;

// Accessing the PerlinMarbleTextureType Guid
Guid perlinMarbleGuid = ContentUuids.PerlinMarbleTextureType;

// You can then use this Guid for various rendering operations.
Console.WriteLine($"Perlin Marble Texture Type Guid: {perlinMarbleGuid}");
```

--------------------------------

### DraftAngleAnalysisSettings() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.draftangleanalysissettings/draftangleanalysissettings

Initializes a new instance of the DraftAngleAnalysisSettings class. This constructor does not take any parameters.

```APIDOC
## DraftAngleAnalysisSettings()

### Description
Initializes a new instance of the DraftAngleAnalysisSettings class.

### Method
Constructor

### Endpoint
N/A (Class constructor)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Instance Creation)
- **Instance** (DraftAngleAnalysisSettings) - A new instance of the DraftAngleAnalysisSettings class.

#### Response Example
```csharp
var settings = new Rhino.ApplicationSettings.DraftAngleAnalysisSettings();
```
```

--------------------------------

### IZooClientUtilities - ReturnLicense Method (Overload 2)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.izooclientutilities/returnlicense

This overload of the ReturnLicense method verifies and returns a license using an Object, a String product path, and a Guid.

```APIDOC
## ReturnLicense (Overload 2)

### Description
Verifies and returns a license using an Object, a String product path, and a Guid.

### Method
Protected (implied, as not explicitly public)

### Endpoint
N/A (This is a method within a class, not a REST API endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "verify": "object_value",
  "productPath": "/path/to/product",
  "productId": "00000000-0000-0000-0000-000000000000"
}
```

### Response
#### Success Response (Boolean)
- **return_value** (Boolean) - True if the license was successfully returned, false otherwise.

#### Response Example
```json
{
  "return_value": true
}
```

### Available Since
6.0
```

--------------------------------

### Rhino.PlugIns.PlugIn.LoadPlugIn(Guid)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/loadplugin

Loads an installed plug-in using its unique identifier.

```APIDOC
## Rhino.PlugIns.PlugIn.LoadPlugIn(Guid)

### Description
Loads an installed plug-in using its unique identifier.

### Method
`public static Boolean LoadPlugIn(Guid pluginId)`

### Parameters
#### Path Parameters
* None

#### Query Parameters
* None

#### Request Body
* None

### Request Example
```json
{
  "pluginId": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

### Response
#### Success Response (200)
* **Type**: Boolean - True if successful, False otherwise.

#### Response Example
```json
{
  "success": true
}
```

**Available since**: 5.0
```

--------------------------------

### FileDgn Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filedgn/filedgn

Initializes a new instance of the FileDgn class.

```APIDOC
## FileDgn()

### Description
Initializes a new instance of the FileDgn class.

### Method

`CONSTRUCTOR`

### Endpoint

`Rhino.FileIO.FileDgn.FileDgn()`

### Parameters

*No parameters for this constructor.*

### Request Example

*This is a constructor and does not have a request example.*

### Response

*This is a constructor and does not have a response example.*

### Error Handling

*N/A*
```

--------------------------------

### VisualAnalysisMode.Id Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.visualanalysismode/id

Gets the visual analysis mode GUID, which is specified with the System.Runtime.InteropServices.GuidAttribute applied to the class.

```APIDOC
## VisualAnalysisMode.Id Property

### Description
Gets the visual analysis mode GUID. The Guid is specified with the **System.Runtime.InteropServices.GuidAttribute** applied to the class.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Display/VisualAnalysisMode/Id

### Parameters

### Request Body

### Request Example

### Response
#### Success Response (200)
- **Id** (Guid) - The GUID of the visual analysis mode.

#### Response Example
```json
{
  "Id": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```
```

--------------------------------

### MeshInstance.AncestryRecord Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.changequeue.meshinstance.ancestryrecord/meshinstance

Initializes a new instance of the MeshInstance.AncestryRecord class.

```APIDOC
## MeshInstance.AncestryRecord()

### Description
Initializes a new instance of the MeshInstance.AncestryRecord class.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Render.ChangeQueue/MeshInstance.AncestryRecord

### Parameters
None

### Request Example
```json
{
  "example": ""
}
```

### Response
#### Success Response (200)
- **instance** (MeshInstance.AncestryRecord) - A new instance of the MeshInstance.AncestryRecord class.

#### Response Example
```json
{
  "example": "new MeshInstance.AncestryRecord()"
}
```
```

--------------------------------

### GET /Rhino.Commands/Command/LastCommandId

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.commands.command/lastcommandid

Retrieves the Guid of the last command that was executed.

```APIDOC
## GET /Rhino.Commands/Command/LastCommandId

### Description
Gets the ID of the last commands.

### Method
GET

### Endpoint
/Rhino.Commands/Command/LastCommandId

### Parameters

### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Id** (Guid) - The unique identifier of the last executed command.

#### Response Example
{
  "Id": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

--------------------------------

### ZebraAnalysisSettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.zebraanalysissettings/zebraanalysissettings

Initializes a new instance of the ZebraAnalysisSettings class.

```APIDOC
## ZebraAnalysisSettings()

### Description
Initializes a new instance of the ZebraAnalysisSettings class.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.ApplicationSettings/ZebraAnalysisSettings

### Parameters
No parameters are defined for this constructor.

### Request Example
This is a constructor, no request body is applicable.

### Response
#### Success Response (200)
- **ZebraAnalysisSettings** (object) - An initialized instance of the ZebraAnalysisSettings class.

#### Response Example
```json
{
  "message": "ZebraAnalysisSettings instance created successfully."
}
```
```

--------------------------------

### Triangle3d.AltitudeB

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.triangle3d/altitudeb

Gets the altitude line starting at corner B of a Triangle3d object.

```APIDOC
## GET /websites/developer_rhino3d_api/Rhino.Geometry/Triangle3d/AltitudeB

### Description
Gets the altitude line starting at corner B of a Triangle3d.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Geometry/Triangle3d/AltitudeB

### Parameters
#### Query Parameters
None

### Request Example
```json
{
  "example": "No request body needed for this property retrieval."
}
```

### Response
#### Success Response (200)
- **AltitudeB** (Line) - The altitude line starting at corner B.

#### Response Example
```json
{
  "AltitudeB": {
    "From": {"X": 0.0, "Y": 0.0, "Z": 0.0},
    "To": {"X": 1.0, "Y": 1.0, "Z": 1.0},
    "Length": 1.7320508075688772
  }
}
```

### Remarks
Available since RhinoCommon version 7.1.
```

--------------------------------

### KeyboardShortcut Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.keyboardshortcut/keyboardshortcut

Initializes a new instance of the KeyboardShortcut class.

```APIDOC
## KeyboardShortcut Constructor

### Description
Initializes a new instance of the KeyboardShortcut class.

### Method
`KeyboardShortcut()`

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Body
None

### Request Example
```json
{
  "example": "KeyboardShortcut()"
}
```

### Response
#### Success Response (200)
Initializes a KeyboardShortcut object.

#### Response Example
```json
{
  "example": "KeyboardShortcut object initialized"
}
```
```

--------------------------------

### Get Installed Rhino Plug-in Names (Basic)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getinstalledpluginnames

Returns the names of all installed Rhino plug-ins. This is a fundamental method for querying plug-in information without any specific filtering. It returns an array of strings, where each string is the name of an installed plug-in. Available since RhinoCommon 5.0.

```csharp
public static String[] GetInstalledPlugInNames()
{
  // Returns the names if successful.
}
```

--------------------------------

### User Data and Miscellaneous

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Surface

Methods for attaching user data and finding shortest paths.

```APIDOC
## Set User String

### Description
Attaches a user-defined string (key-value pair) to the surface.

### Method
(Implied)

### Endpoint
(Not applicable)

### Parameters
- **key** (String) - The key for the user string.
- **value** (String) - The value of the user string.

### Request Example
(Not applicable)

### Response
#### Success Response (200)
- **Boolean** (bool) - True if the string was set successfully, false otherwise.

#### Response Example
(Not applicable)
```

```APIDOC
## Short Path

### Description
Constructs a geodesic path between two points on the surface, used by the ShortPath command in Rhino.

### Method
(Implied)

### Endpoint
(Not applicable)

### Parameters
- **start** (Point2d) - The starting point on the surface.
- **end** (Point2d) - The ending point on the surface.
- **tolerance** (Double) - The tolerance for finding the path.

### Request Example
(Not applicable)

### Response
#### Success Response (200)
- **Curve** (object) - The geodesic curve representing the shortest path.

#### Response Example
(Not applicable)
```

--------------------------------

### Point3fKNeighbors C# Example

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.collections.rhinolist/point3fkneighbors

Demonstrates how to use the Point3fKNeighbors method to find the k-closest points. This method is useful for spatial queries and neighbor searches within a point cloud. It takes a point cloud, a set of points to search for, and the desired number of neighbors as input.

```csharp
using Rhino.Collections;
using Rhino.Geometry;
using System.Collections.Generic;

// Example usage:
IEnumerable<Point3f> hayPoints = new List<Point3f> { new Point3f(0, 0, 0), new Point3f(1, 1, 1), new Point3f(2, 2, 2) };
IEnumerable<Point3f> needlePoints = new List<Point3f> { new Point3f(0.5, 0.5, 0.5), new Point3f(1.8, 1.8, 1.8) };
int amount = 1;

IEnumerable<int[]> neighbors = RhinoList.Point3fKNeighbors(hayPoints, needlePoints, amount);

foreach (var neighborIndices in neighbors)
{
    foreach (var index in neighborIndices)
    {
        // Process neighbor index
        System.Console.WriteLine($"Neighbor index: {index}");
    }
}
```

--------------------------------

### FileAi Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileai/fileai

Initializes a new instance of the FileAi class.

```APIDOC
## FileAi Constructor

### Description
Initializes a new instance of the FileAi class.

### Method
CONSTRUCTOR

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "constructor": "FileAi()"
}
```

### Response
#### Success Response (200)
This is a constructor, so it initializes an object in memory.

#### Response Example
```json
{
  "instance": "FileAi object"
}
```
```

--------------------------------

### Get WireframeIsocurvesRGBA Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectuuids/wireframeisocurvesrgba

Retrieves the Guid for wireframe isocurves using the WireframeIsocurvesRGBA property. This property belongs to the PostEffectUuids class within the Rhino.Render.PostEffects namespace.

```csharp
public static Guid WireframeIsocurvesRGBA {get}
```

--------------------------------

### File3dm Constructor

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_FileIO_File3dm

Initializes a new instance of the File3dm class, representing an empty .3dm file.

```APIDOC
## File3dm()

### Description
Initializes a new instance of a 3dm file.

### Method
GET

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
None

### Response
None

### Response Example
None
```

--------------------------------

### Get WoodTextureType Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/woodtexturetype

Retrieves the static Guid value for the wood texture type. This property is part of the Rhino.Render.ContentUuids class and is available from version 6.0 onwards.

```csharp
public static Guid WoodTextureType {get}
```

--------------------------------

### Rhino.PlugIns.PlugIn.PathFromId

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/pathfromid

Gets the path to an installed plug-in given the id of that plug-in.

```APIDOC
## Rhino.PlugIns.PlugIn.PathFromId

### Description
Gets the path to an installed plug-in given the id of that plug-in.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.PlugIns/PlugIn/PathFromId

### Parameters
#### Query Parameters
- **pluginId** (Guid) - Required - The unique identifier of the plug-in.

### Request Example
```json
{
  "pluginId": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

### Response
#### Success Response (200)
- **path** (String) - The file path to the installed plug-in.

#### Response Example
```json
{
  "path": "C:\\Program Files\\Rhinoceros 5\\Plug-ins\\MyPlugin.rhp"
}
```
```

--------------------------------

### Get Guid at Index using SimpleArrayGuidPointer

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.interopwrappers.simplearrayguidpointer/item

The `this[int index]` property of the `SimpleArrayGuidPointer` class allows you to retrieve a `Guid` object from the underlying pointer array at a specified index. This is useful for accessing Guid collections managed through interop.

```csharp
public Guid this[int index]
{
    // Implementation details to retrieve Guid at index
}
```

--------------------------------

### Brep.CreateFromLoftRebuild (5.0)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfromloftrebuild

Constructs one or more Breps by lofting through a set of curves. Input for the loft is simplified by rebuilding to a specified number of control points.

```APIDOC
## Brep.CreateFromLoftRebuild

### Description
Constructs one or more Breps by lofting through a set of curves. Input for the loft is simplified by rebuilding to a specified number of control points.

### Method
`public static Brep[] CreateFromLoftRebuild(
    IEnumerable<Curve> curves,
    Point3d start,
    Point3d end,
    LoftType loftType,
    Boolean closed,
    Int32 rebuildPointCount
)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
* **curves** (IEnumerable<Curve>) - Required - The curves to loft through. This function will not perform any curve sorting. You must pass in curves in the order you want them lofted. This function will not adjust the directions of open curves. Use Curve.DoDirectionsMatch and Curve.Reverse to adjust the directions of open curves. This function will not adjust the seams of closed curves. Use Curve.ChangeClosedCurveSeam to adjust the seam of closed curves.
* **start** (Point3d) - Optional - Optional starting point of loft. Use Point3d.Unset if you do not want to include a start point.
* **end** (Point3d) - Optional - Optional ending point of loft. Use Point3d.Unset if you do not want to include an end point.
* **loftType** (LoftType) - Required - Type of loft to perform.
* **closed** (System.Boolean) - Required - True if the last curve in this loft should be connected back to the first one.
* **rebuildPointCount** (System.Int32) - Required - A number of points to use while rebuilding the curves. 0 leaves turns this parameter off.

### Request Example
```json
{
  "curves": [],
  "start": null,
  "end": null,
  "loftType": null,
  "closed": false,
  "rebuildPointCount": 0
}
```

### Response
#### Success Response (200)
* **Brep[]** - Constructs a closed surface, continuing the surface past the last curve around to the first curve. Available when you have selected three shape curves.

#### Response Example
```json
[
  {
    "example": "Brep object"
  }
]
```

Available since: 5.0
```

--------------------------------

### GetMaterial (ComponentIndex, Guid)

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_DocObjects_RhinoObject

Gets the Material associated with a sub-object, identified by component index and plug-in ID.

```APIDOC
## GetMaterial (ComponentIndex, Guid)

### Description
Get the Material associated with the sub object identified by componentIndex if the component index is set to ComponentIndex.Unset then the top level material is returned.

### Method
N/A (Assumed to be a method call on an object)

### Endpoint
N/A

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```
material = object.GetMaterial(componentIndex, plugInId)
```

### Response
#### Success Response (200)
- **material** (Material) - The Material associated with the sub-object.
```

--------------------------------

### ViewCaptureWriter.Pen Class Overview

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.viewcapturewriter

Provides information about the ViewCaptureWriter.Pen class, its constructors, and properties.

```APIDOC
## ViewCaptureWriter.Pen Class

### Description
Initializes a new instance of the ViewCaptureWriter.Pen class and details its properties.

### Namespace
Rhino.Runtime

### Constructors
#### ViewCaptureWriter.Pen()
Initializes a new instance of the ViewCaptureWriter.Pen class.

### Properties
#### Cap
Details about the Cap property.

#### Color
Details about the Color property.

#### Join
Details about the Join property.

#### Pattern
Details about the Pattern property.

#### Width
Details about the Width property.
```

--------------------------------

### Get Render Engine Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.lightmanagersupport/renderengineid

Retrieves the unique Guid identifier for the render engine associated with the light manager. This method is part of the Rhino.Render.LightManagerSupport class and returns a Guid object. It is available in RhinoCommon version 6.0 and later.

```csharp
public abstract Guid RenderEngineId()
{
  // Returns the Guid of the render engine that is associated with this light manager
}
```

--------------------------------

### Get RealtimeDisplayMaterialType Guid

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/realtimedisplaymaterialtype

This property returns a Guid that identifies the RealtimeDisplayMaterialType. It is a static property of the ContentUuids class within the Rhino.Render namespace. No specific inputs are required, and it returns a Guid value. This property has been available since RhinoCommon version 6.0.

```csharp
public static Guid RealtimeDisplayMaterialType {get}
```

--------------------------------

### FilePovWriteOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filepovwriteoptions/filepovwriteoptions

Initializes a new instance of the FilePovWriteOptions class.

```APIDOC
## FilePovWriteOptions()

### Description
Initializes a new instance of the FilePovWriteOptions class.

### Method
CONSTRUCTOR

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "FilePovWriteOptions()"
}
```

### Response
#### Success Response (200)
- **instance** (FilePovWriteOptions) - A new instance of the FilePovWriteOptions class.

#### Response Example
```json
{
  "example": "Instance of FilePovWriteOptions created."
}
```
```

--------------------------------

### GET /Sun

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.tables.lighttable/sun

Gets the Sun instance that is applied to the document. If the RDK is loaded, an instance is always returned.

```APIDOC
## GET /Sun

### Description
Gets the Sun instance that is applied to the document. If the RDK is loaded, an instance is always returned.

### Method
GET

### Endpoint
/Sun

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Sun** (Sun) - The Sun instance applied to the document.

#### Response Example
```json
{
  "Sun": { ... }
}
```
```

--------------------------------

### Arc Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Arc

Provides details on the various ways to initialize a new Arc instance.

```APIDOC
## Arc Constructors

### Description
Initializes a new instance of an Arc.

### Constructors

*   **Arc**(Circle circle, double angleRadians)
    Initializes a new instance of an arc from a base circle and an angle.
*   **Arc**(Circle circle, Interval angleIntervalRadians)
    Initializes a new instance of an arc from a base circle and an interval of angles.
*   **Arc**(Plane plane, double radius, double angleRadians)
    Initializes a new arc from a base plane, a radius value and an angle.
*   **Arc**(Plane plane, Point3d center, double radius, double angleRadians)
    Initializes a new aligned arc at the given center point, with a custom radius and angle.
*   **Arc**(Point3d center, double radius, double angleRadians)
    Initializes a new horizontal arc at the given center point, with a custom radius and angle.
*   **Arc**(Point3d pointA, Vector3d tangentA, Point3d pointB)
    Initializes a new arc from end points and a tangent vector. If the tangent is parallel with the line segment between the two endpoints this will result in an Invalid arc.
*   **Arc**(Point3d startPoint, Point3d pointOnInterior, Point3d endPoint)
    Initializes a new arc through three points. If the points are coincident or co-linear, this will result in an Invalid arc.
```

--------------------------------

### Get RhinoEmapAnalysisModeId Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.visualanalysismode/rhinoemapanalysismodeid

Retrieves the static Guid identifier for Rhino's built-in emap analysis mode. This mode is used to display environment maps on surfaces and meshes. The Guid is accessible via the RhinoEmapAnalysisModeId property.

```csharp
System.Guid id = Rhino.Display.VisualAnalysisMode.RhinoEmapAnalysisModeId;

```

--------------------------------

### DimensionStyle Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_DocObjects_DimensionStyle

Details on how to construct and initialize a DimensionStyle object.

```APIDOC
## DimensionStyle Constructors

### Description
Allows for the creation and initialization of DimensionStyle objects.

### Method
`new` (constructor)

### Endpoints
N/A (Class constructors)

### Parameters
#### Constructor: CommonObject()
- None

#### Constructor: CommonObject(SerializationInfo info, StreamingContext context)
- **info** (SerializationInfo) - The serialization information.
- **context** (StreamingContext) - The streaming context.

#### Constructor: DimensionStyle()
- None

#### Constructor: DimensionStyle(SerializationInfo info, StreamingContext context)
- **info** (SerializationInfo) - The serialization information.
- **context** (StreamingContext) - The streaming context.

### Request Example
```json
// Example for creating a new non-document controlled style
DimensionStyle myStyle = new DimensionStyle();
```

### Response
#### Success Response (N/A - Constructor)
N/A

#### Response Example
N/A
```

--------------------------------

### Get ToneMapper BlackWhitePoint Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectuuids/tonemapper_blackwhitepoint

Retrieves the Guid that identifies the tone mapper's black and white point setting. This is a static property of the PostEffectUuids class within the Rhino.Render.PostEffects namespace. It does not take any input parameters and returns a Guid.

```csharp
public static Guid ToneMapper_BlackWhitePoint {get}
```

--------------------------------

### Get Installed Rhino Plug-in Names (Filtered by Type, Load State, and Localization)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getinstalledpluginnames

Gets a list of installed plug-in names, with options to filter by plug-in type, whether they are loaded or unloaded, and whether to return localized or English names. This provides granular control over the returned plug-in list. Available since RhinoCommon 7.5.

```csharp
public static String[] GetInstalledPlugInNames(
  PlugInType typeFilter,
  Boolean loaded,
  Boolean unloaded,
  Boolean localizedPlugInName
)
{
  // Parameters:
  // * typeFilter: Enumeration flags for plug-in types.
  // * loaded: True to include loaded plug-ins.
  // * unloaded: True to include unloaded plug-ins.
  // * localizedPlugInName: True for localized names, False for English names.
  // Returns: An array of installed plug-in names (can be empty, but not null).
}
```

--------------------------------

### Get Guid Id Property - RhinoCommon API

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.controls.icollapsiblesection/id

Retrieves the unique identifier (Guid) for an ICollapsibleSection instance. This property is read-only and is available since RhinoCommon version 6.0.

```csharp
protected Guid Id { get; }
```

--------------------------------

### SmartTrackSettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.smarttracksettings/smarttracksettings

This endpoint documents the constructor for the SmartTrackSettings class, which initializes a new instance of the class.

```APIDOC
## SmartTrackSettings()

### Description
Initializes a new instance of the SmartTrackSettings class.

### Method
CONSTRUCTOR

### Endpoint
Rhino.ApplicationSettings.SmartTrackSettings

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{
  "example": "SmartTrackSettings()"
}
```

### Response
#### Success Response (200)
An initialized instance of the SmartTrackSettings class.

#### Response Example
```json
{
  "example": "SmartTrackSettings object"
}
```
```

--------------------------------

### Get Current Renderer GUID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.datasources.rhinosettings/getcurrentrenderer

Retrieves the unique identifier (GUID) of the currently active renderer in Rhino. This method is part of the Rhino.Render.DataSources.RhinoSettings class and is available from version 8.17 onwards.

```csharp
public Guid GetCurrentRenderer()
{
    // Implementation details to retrieve the current renderer's GUID
    // Returns a Guid representing the current renderer.
    return Guid.Empty; // Placeholder
}
```

--------------------------------

### Rhino.Geometry.Brep.CreateFromBox (Box)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfrombox

Constructs a new Brep that matches a given Box.

```APIDOC
## POST /Rhino.Geometry.Brep/CreateFromBox

### Description
Constructs new brep that matches an aligned box.

### Method
POST

### Endpoint
/Rhino.Geometry.Brep/CreateFromBox

### Parameters
#### Request Body
- **box** (Box) - Required - Box to match.

### Request Example
```json
{
  "box": {
    "plane": {
      "origin": {"x": 0, "y": 0, "z": 0},
      "xAxis": {"x": 1, "y": 0, "z": 0},
      "yAxis": {"x": 0, "y": 1, "z": 0}
    },
    "width": 1,
    "height": 1,
    "depth": 1
  }
}
```

### Response
#### Success Response (200)
- **brep** (Brep) - A Brep with 6 faces that is similar to the Box.

#### Response Example
```json
{
  "brep": {
    "faces": [...],
    "edges": [...],
    "vertices": [...]
  }
}
```
```

--------------------------------

### Get MarbleTextureType Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/marbletexturetype

Retrieves the Guid value for the MarbleTextureType. This property is static and read-only, returning a Guid representing the texture type. It is available in RhinoCommon version 6.0 and later.

```csharp
public static Guid MarbleTextureType { get; }
```

--------------------------------

### Rhino.Runtime.HostUtils.CreateCommands (Int32)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/createcommands

Parses a plugin and creates all the commands defined therein. This overload returns the number of newly created commands.

```APIDOC
## CreateCommands (Int32)

### Description
Parses a plugin and create all the commands defined therein, returning the count of created commands.

### Method
`public static Int32 CreateCommands(IntPtr pPlugIn, Assembly pluginAssembly)`

### Endpoint
N/A (This is a static method, not an HTTP endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "pPlugIn": "<IntPtr object>",
  "pluginAssembly": "<Assembly object>"
}
```

### Response
#### Success Response (200)
- **return value** (Int32) - The number of newly created commands.

#### Response Example
```json
{
  "returnValue": 5
}
```
```

--------------------------------

### Ray3d Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Ray3d

Information on how to create new instances of the Ray3d struct.

```APIDOC
## Ray3d Constructor

### Description
Initializes a new Ray3d instance.

### Method
CONSTRUCTOR

### Endpoint
N/A

### Parameters
#### Path Parameters
N/A

#### Query Parameters
N/A

#### Request Body
N/A

### Request Example
```json
{
  "position": {"x": 0.0, "y": 0.0, "z": 0.0},
  "direction": {"x": 0.0, "y": 0.0, "z": 1.0}
}
```

### Response
#### Success Response (200)
N/A (Constructor)

#### Response Example
N/A (Constructor)
```

--------------------------------

### Rhino.Geometry.Collections.NurbsCurveKnotList.IsClampedStart

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.collections.nurbscurveknotlist/isclampedstart

Gets a value indicating whether or not the knot vector is clamped at the start of the curve. Clamped curves start at the first control-point. This requires fully multiple knots.

```APIDOC
## Rhino.Geometry.Collections.NurbsCurveKnotList.IsClampedStart

### Description
Gets a value indicating whether or not the knot vector is clamped at the start of the curve. Clamped curves start at the first control-point. This requires fully multiple knots.

### Method
GET

### Endpoint
/Rhino.Geometry.Collections.NurbsCurveKnotList/IsClampedStart

### Parameters
None

### Request Example
```json
{
  "method": "GET",
  "endpoint": "/Rhino.Geometry.Collections.NurbsCurveKnotList/IsClampedStart"
}
```

### Response
#### Success Response (200)
- **IsClampedStart** (bool) - Returns true if the knot vector is clamped at the start of the curve, false otherwise.

#### Response Example
```json
{
  "IsClampedStart": true
}
```

### Remarks
Available since: 5.0
```

--------------------------------

### FileSlcWriteOptions() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileslcwriteoptions/fileslcwriteoptions

Initializes a new instance of the FileSlcWriteOptions class with default settings.

```APIDOC
## FileSlcWriteOptions()

### Description
Initializes a new instance of the FileSlcWriteOptions class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "constructor": "FileSlcWriteOptions()"
}
```

### Response
#### Success Response (200)
An instance of the FileSlcWriteOptions class is created.

#### Response Example
```json
{
  "instance": "FileSlcWriteOptions"
}
```
```

--------------------------------

### GET /Materials Panel ID

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/materials

Retrieves the unique GUID for the Rhino Materials panel.

```APIDOC
## GET /Materials Panel ID

### Description
Retrieves the unique identifier (GUID) for the Rhino Materials panel, allowing programmatic access or reference to this panel within the Rhino UI.

### Method
GET

### Endpoint
/Materials

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
- **Materials** (Guid) - The unique identifier for the Rhino Materials panel.

#### Response Example
{
  "Materials": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}

### Remarks
This property is available starting from RhinoCommon version 5.0.
```

--------------------------------

### Create Brep from Curves (Loft) with Tangent Matching (RhinoCommon C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfromloft

Constructs one or more Breps by lofting through curves, with options to match start and end tangents of surfaces when the first/last curves are surface edges. Requires careful handling of start/end points and trims. Curves must be pre-sorted.

```csharp
public static Brep[] CreateFromLoft(
  IEnumerable<Curve> curves,
  Point3d start,
  Point3d end,
  Boolean StartTangent,
  Boolean EndTangent,
  BrepTrim StartTrim,
  BrepTrim EndTrim,
  LoftType loftType,
  Boolean closed
)
```

--------------------------------

### Item Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.interopwrappers.simplearrayguidpointer/item

Gets the Guid at a specific index in the SimpleArrayGuidPointer.

```APIDOC
## GET /websites/developer_rhino3d_api/Rhino.Runtime.InteropWrappers/SimpleArrayGuidPointer/Item

### Description
Gets the Guid at the specified index.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Runtime.InteropWrappers/SimpleArrayGuidPointer/Item

### Parameters
#### Query Parameters
- **index** (int) - Required - The index of the Guid to retrieve.

### Response
#### Success Response (200)
- **Guid** (Guid) - The Guid at the specified index.

#### Response Example
```json
{
  "guid": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```
```

--------------------------------

### ViewportInfo Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_DocObjects_ViewportInfo

Provides details on the different ways to instantiate the ViewportInfo class.

```APIDOC
## ViewportInfo Constructors

### Description
Constructors for initializing a ViewportInfo object.

### CommonObject()
Allows construction from inheriting classes.

### CommonObject(SerializationInfo info, StreamingContext context)
Protected constructor for internal use.

### ViewportInfo()
Initializes a new instance of the ViewportInfo class.

### ViewportInfo(RhinoViewport rhinoViewport)
Copies all of the ViewportInfo data from an existing RhinoViewport.

### ViewportInfo(ViewportInfo other)
Initializes a new instance by copying values from another ViewportInfo instance.
```

--------------------------------

### RhinoObject HistoryChildren

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.rhinoobject/historychildren

Gets the GUIDs of the child Rhino objects of this RhinoObject.

```APIDOC
## Rhino.DocObjects.RhinoObject HistoryChildren

### Description
Gets the IDs of the child Rhino objects of this object.

### Method
`public Guid[] HistoryChildren()`

### Endpoint
N/A (This is a method within the RhinoCommon SDK, not a REST API endpoint)

### Parameters
This method does not take any parameters.

### Request Example
```csharp
// Assuming 'rhinoObject' is an instance of Rhino.DocObjects.RhinoObject
Guid[] childIds = rhinoObject.HistoryChildren();
```

### Response
#### Success Response
- **Guid[]** - An array of Rhino object IDs if successful, an empty array if the object has no children or on error.

#### Response Example
```json
[
  "a1b2c3d4-e5f6-7890-1234-567890abcdef",
  "fedcba09-8765-4321-0fed-cba098765432"
]
```

**Available since:** 8.13
```

--------------------------------

### AppearanceSettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.appearancesettings/appearancesettings

Initializes a new instance of the AppearanceSettings class. This is a no-argument constructor.

```APIDOC
## AppearanceSettings()

### Description
Initializes a new instance of the AppearanceSettings class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "AppearanceSettings()"
}
```

### Response
#### Success Response (Instance)
- **AppearanceSettings** (AppearanceSettings) - An initialized instance of the AppearanceSettings class.

#### Response Example
```json
{
  "example": "An instance of AppearanceSettings"
}
```
```

--------------------------------

### InstallationTypeString Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/installationtypestring

Retrieves the type of installation (product edition) of the license or lease for Rhino.

```APIDOC
## InstallationTypeString Property

### Description
Gets the type of installation (product edition) of the license or lease.

### Method
GET

### Endpoint
/RhinoApp/InstallationTypeString

### Parameters
#### Query Parameters
None

#### Path Parameters
None

### Request Example
None (This is a property getter)

### Response
#### Success Response (200)
- **installationType** (string) - The type of installation (e.g., Commercial, Education, NotLicensed).

#### Response Example
```json
{
  "installationType": "Commercial"
}
```
```

--------------------------------

### PointCountAt Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.interopwrappers.simplearrayarraypoint3d/pointcountat

Gets the amount of points in a polyline. This method is available starting from Rhino version 7.0.

```APIDOC
## PointCountAt Method

### Description
Gets the amount of points in a polyline.

### Method
public Int32 PointCountAt(Int32 index)

### Endpoint
Rhino.Runtime.InteropWrappers.SimpleArrayArrayPoint3d

### Parameters
#### Path Parameters
- None

#### Query Parameters
- None

#### Request Body
- **index** (Int32) - The index of the polyline.

### Request Example
```json
{
  "index": 0
}
```

### Response
#### Success Response (200)
- **Return Value** (Int32) - The number of points in the specified polyline.

#### Response Example
```json
{
  "returnValue": 10
}
```
```

--------------------------------

### ColorGradient Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.colorgradient/colorgradient

Initializes a new instance of the ColorGradient class.

```APIDOC
## ColorGradient Constructor

### Description
Initializes a new instance of the ColorGradient class.

### Method
`new` (Constructor)

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "new ColorGradient()"
}
```

### Response
#### Success Response (200)
N/A (Constructor does not return a value in the traditional sense, it initializes an object)

#### Response Example
```json
{
  "example": "// Instantiates a ColorGradient object"
}
```
```

--------------------------------

### Rhino.Geometry.Brep.CreatePatch (Simple)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createpatch

Constructs a brep patch using a specified starting surface. This is a simplified version of the fit operation.

```APIDOC
## Rhino.Geometry.Brep.CreatePatch (Simple Overload)

### Description
Constructs a brep patch using a specified starting surface. This is a simplified version of the fit operation.

### Method
`public static Brep CreatePatch(
    IEnumerable<GeometryBase> geometry,
    Surface startingSurface,
    Double tolerance
)`

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **geometry** (IEnumerable<GeometryBase>) - Required - Combination of Curves, BrepTrims, Points, PointClouds or Meshes. Curves and trims are sampled to get points. Trims are sampled for points and normals.
- **startingSurface** (Surface) - Optional - A starting surface (can be null).
- **tolerance** (System.Double) - Required - Tolerance used by input analysis functions for loop finding, trimming, etc.

### Request Example
```json
{
  "geometry": [],
  "startingSurface": null,
  "tolerance": 0.01
}
```

### Response
#### Success Response (200)
- **Brep** (Brep) - Brep fit through input on success, or null on error.

#### Response Example
```json
{
  "brep": "[Brep Object Representation]"
}
```

### Available since
5.0
```

--------------------------------

### FileGltfWriteOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filegltfwriteoptions/filegltfwriteoptions

Initializes a new instance of the FileGltfWriteOptions class.

```APIDOC
## FileGltfWriteOptions()

### Description
Initializes a new instance of the FileGltfWriteOptions class.

### Method
Constructor

### Endpoint
Rhino.FileIO.FileGltfWriteOptions

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{
  "example": "FileGltfWriteOptions()"
}
```

### Response
#### Success Response (200)
- **instance** (FileGltfWriteOptions) - A new instance of the FileGltfWriteOptions class.

#### Response Example
```json
{
  "example": "// Code to instantiate FileGltfWriteOptions"
}
```
```

--------------------------------

### RhinoDoc Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinodoc/rhinodoc

Initializes a new instance of the RhinoDoc class.

```APIDOC
## RhinoDoc Constructor

### Description
Initializes a new instance of the RhinoDoc class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "constructor": "RhinoDoc()"
}
```

### Response
#### Success Response (200)
- **RhinoDoc** (object) - An initialized RhinoDoc object.

#### Response Example
```json
{
  "instance": "RhinoDoc object"
}
```
```

--------------------------------

### FileVrmlWriteOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filevrmlwriteoptions/filevrmlwriteoptions

Initializes a new instance of the FileVrmlWriteOptions class.

```APIDOC
## FileVrmlWriteOptions()

### Description
Initializes a new instance of the FileVrmlWriteOptions class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
An instance of FileVrmlWriteOptions.

#### Response Example
None
```

--------------------------------

### Box.ToBrep Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.box/tobrep

Constructs a brep representation of this box.

```APIDOC
## Box.ToBrep Method

### Description
Constructs a brep representation of this box.

### Method
`public Brep ToBrep()`

### Endpoint
N/A (Method within a class)

### Parameters
None

### Request Example
```json
{
  "example": "N/A"
}
```

### Response
#### Success Response
- **Brep** (Type: Brep) - A Brep representation of this box or null.

#### Response Example
```json
{
  "example": "Brep object or null"
}
```

### Availability
- Available since: 5.0
```

--------------------------------

### Get BoxEdit Panel ID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/boxedit

Retrieves the unique identifier (Guid) for the Rhino BoxEdit panel. This property is static and does not require an instance of any class to be accessed. The value returned is a Guid.

```csharp
public static Guid BoxEdit { get; }
```

--------------------------------

### Rhino.Render.SupportOptions.UseQuickInitialPreview

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.supportoptions/usequickinitialpreview

This method controls whether a quick initial preview is used. It is available since RhinoCommon version 6.0.

```APIDOC
## UseQuickInitialPreview method

### Description
Controls whether a quick initial preview is used. Available since RhinoCommon version 6.0.

### Method
public static Boolean UseQuickInitialPreview()

### Endpoint
N/A (This is a static method within a class)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (N/A for method call, returns Boolean)
- **Return Value** (Boolean) - True if quick initial preview is used, False otherwise.

#### Response Example
```json
{
  "returnValue": true
}
```
```

--------------------------------

### Get WireframePointsRGBA Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectuuids/wireframepointsrgba

Retrieves the static Guid value representing the wireframe points color using the RhinoCommon API. This property is available from version 8.13 onwards.

```csharp
using Rhino.Render.PostEffects;

// Retrieve the Guid for wireframe points color
Guid wireframeColorGuid = PostEffectUuids.WireframePointsRGBA;
```

--------------------------------

### FileSlcWriteOptions.StartPoint Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileslcwriteoptions/startpoint

Provides access to the starting point for slicing operations within the FileSlcWriteOptions class.

```APIDOC
## FileSlcWriteOptions.StartPoint Property

### Description
Gets or sets the starting point for the slicing operation.

### Method
Get | Set

### Endpoint
Rhino.FileIO.FileSlcWriteOptions.StartPoint

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "Not applicable for property access"
}
```

### Response
#### Success Response (200)
- **Point3d** (Type) - The starting point for the slicing operation.

#### Response Example
```json
{
  "example": "(x, y, z)"
}
```
```

--------------------------------

### Rhino.Runtime.IZooClientUtilities.Initialize

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.izooclientutilities/initialize

Initializes the Zoo client utilities. This method is protected and returns a boolean value indicating success.

```APIDOC
## Initialize method

### Description
Initializes the Zoo client utilities. This method is protected and returns a boolean value indicating success or failure.

### Method
Protected

### Endpoint
Rhino.Runtime/IZooClientUtilities/Initialize

### Parameters
#### Path Parameters
- **verify** (Object) - Optional - Description not provided.

### Request Example
```json
{
  "verify": null 
}
```

### Response
#### Success Response (200)
- **Boolean** (Boolean) - Indicates whether the initialization was successful.

#### Response Example
```json
{
  "success": true
}
```

### Availability
Available since version 6.0.
```

--------------------------------

### Get or Set Line FromX Coordinate (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.line/fromx

This property retrieves or modifies the X-coordinate of the starting point of a Rhino line object. It is a double-precision floating-point number. Availability starts from version 5.0.

```csharp
public double FromX { get; set; }
```

--------------------------------

### GetSystemReferenceAssemblies

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_HostUtils

Gets the system reference assemblies for dynamic code compilation.

```APIDOC
## GetSystemReferenceAssemblies

### Description
Gets the system reference assemblies to use when compiling code dynamically with Roslyn. Includes RhinoCommon, Rhino.UI, and Eto.

### Method
N/A (Function signature)

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
* **assemblies** (Array of String) - A list of paths to system reference assemblies.
```

--------------------------------

### Rhino.Runtime.Skin.OnEndLoadAtStartPlugIns

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.skin/onendloadatstartplugins

This method is called after all of the load-at-start plug-ins have been loaded. It's part of the Rhino.Runtime.Skin class.

```APIDOC
## protected virtual Void OnEndLoadAtStartPlugIns()

### Description
This method is called after all of the load at start plug-ins have been loaded.

### Method
Protected Virtual

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Void)
- Returns: Void

#### Response Example
N/A
```

--------------------------------

### ToolbarGroup Id Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.toolbargroup/id

Gets the unique identifier (GUID) of a specific toolbar group.

```APIDOC
## GET /websites/developer_rhino3d_api/Rhino.UI/ToolbarGroup/Id

### Description
Gets the unique identifier (GUID) of the toolbar group.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.UI/ToolbarGroup/Id

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
(Not applicable for a property getter)

### Response
#### Success Response (200)
- **Id** (Guid) - The unique identifier of the toolbar group.

#### Response Example
{
  "Id": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

--------------------------------

### BitmapExtensions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.bitmapextensions/bitmapextensions

Initializes a new instance of the BitmapExtensions class.

```APIDOC
## BitmapExtensions()

### Description
Initializes a new instance of the BitmapExtensions class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Body
None

### Response
#### Success Response (N/A)
This is a constructor, it does not return a value.

#### Response Example
N/A
```

--------------------------------

### Get All Installed Fonts (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.font/installedfonts

Retrieves an array of all fonts installed on the system that are recognized by Rhino. This method is useful for populating font selection lists or checking font availability. It does not require any parameters.

```csharp
public static Font[] InstalledFonts()
{
  // Implementation details to retrieve all installed fonts
  throw new NotImplementedException();
}
```

--------------------------------

### Line Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Line

Demonstrates the different ways to construct a Line object in Rhino3D.

```APIDOC
## Line Constructors

### Description
Constructs a new line segment between two points or from a starting point, direction, and length.

### Method
Various constructors are available depending on the input parameters.

### Endpoints
N/A (Constructor - object instantiation)

### Parameters
#### Constructor: Line(double x0, double y0, double z0, double x1, double y1, double z1)
- **x0** (double) - X coordinate of the start point.
- **y0** (double) - Y coordinate of the start point.
- **z0** (double) - Z coordinate of the start point.
- **x1** (double) - X coordinate of the end point.
- **y1** (double) - Y coordinate of the end point.
- **z1** (double) - Z coordinate of the end point.

#### Constructor: Line(Point3d from, Point3d to)
- **from** (Point3d) - The starting point of the line.
- **to** (Point3d) - The ending point of the line.

#### Constructor: Line(Point3d start, Vector3d direction, double length)
- **start** (Point3d) - The starting point of the line.
- **direction** (Vector3d) - The direction vector of the line.
- **length** (double) - The length of the line.

#### Constructor: Line(Point3d start, Vector3d span)
- **start** (Point3d) - The starting point of the line.
- **span** (Vector3d) - The vector representing the span from the start point to the end point.

### Request Example
```json
{
  "constructor": "Line(Point3d from, Point3d to)",
  "from": {"x": 0, "y": 0, "z": 0},
  "to": {"x": 1, "y": 1, "z": 1}
}
```

### Response
N/A (Constructor - object instantiation)

#### Success Response (200)
N/A

#### Response Example
N/A
```

--------------------------------

### Id Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.toolbarfile/id

Gets the unique identifier (Guid) of the toolbar file.

```APIDOC
## GET /websites/developer_rhino3d_api/Rhino.UI/ToolbarFile/Id

### Description
Gets the id of the toolbar file.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.UI/ToolbarFile/Id

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Id** (Guid) - The unique identifier of the toolbar file.

#### Response Example
```json
{
  "Id": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```
```

--------------------------------

### GetMaterial (ComponentIndex, Guid, Attributes)

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_DocObjects_RhinoObject

Gets the Material associated with a sub-object, identified by component index, plug-in ID, and attributes.

```APIDOC
## GetMaterial (ComponentIndex, Guid, Attributes)

### Description
Get the Material associated with the sub object identified by componentIndex if the component index is set to ComponentIndex.Unset then the top level material is returned.

### Method
N/A (Assumed to be a method call on an object)

### Endpoint
N/A

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```
material = object.GetMaterial(componentIndex, plugInId, attributes)
```

### Response
#### Success Response (200)
- **material** (Material) - The Material associated with the sub-object.
```

--------------------------------

### Rhino.FileIO.FileGtsWriteOptions.MeshingParameters

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filegtswriteoptions/meshingparameters

This property allows you to get or set the MeshingParameters for writing GTS files. It is available starting from version 8.0.

```APIDOC
## Rhino.FileIO.FileGtsWriteOptions.MeshingParameters

### Description
Allows getting or setting the MeshingParameters for writing GTS files.

### Method
public MeshingParameters MeshingParameters {get|set}

### Endpoint
Not applicable (Class Property)

### Parameters
None

### Request Example
```json
{
  "example": "Not applicable for property access"
}
```

### Response
#### Success Response (200)
- **Type**: MeshingParameters - The meshing parameters object.

#### Response Example
```json
{
  "example": "MeshingParameters object"
}
```

### Remarks
Available since: 8.0
```

--------------------------------

### CreateDockBar Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.ipanelsservice/createdockbar

This method is part of the Rhino.UI.IPanelsService and is used to create a dockable bar.

```APIDOC
## CreateDockBar Method

### Description
Creates a dockable bar with specified options.

### Method
Boolean

### Endpoint
Rhino.UI.IPanelsService.CreateDockBar

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **options** (Object) - Required - An object containing options for creating the dock bar.

### Request Example
```json
{
  "options": "..."
}
```

### Response
#### Success Response (200)
- **Boolean** (Boolean) - True if the dock bar was created successfully, false otherwise.

#### Response Example
```json
{
  "success": true
}
```

### Availability
Available since version 8.0.
```

--------------------------------

### File3mf Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3mf/file3mf

Initializes a new instance of the File3mf class.

```APIDOC
## File3mf Constructor

### Description
Initializes a new instance of the File3mf class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Body
None

### Request Example
```
File3mf()
```

### Response
#### Success Response (Instance)
- **File3mf** (Object) - A new instance of the File3mf class.

#### Response Example
```json
{
  "instance": "File3mf object"
}
```
```

--------------------------------

### TextLog(IntPtr ptr) Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.textlog/textlog

Initializes a new instance of the TextLog class using an IntPtr.

```APIDOC
## TextLog(IntPtr ptr)

### Description
Initializes a new instance of the TextLog class using an IntPtr. This constructor is available from version 6.0.

### Method
GET

### Endpoint
/Rhino.FileIO/TextLog/TextLog(IntPtr)

### Parameters
#### Path Parameters
- **ptr** (IntPtr) - Required - The IntPtr to use for initializing the TextLog.

### Request Example
None

### Response
#### Success Response (200)
- **TextLog** (object) - An instance of the TextLog class.

#### Response Example
None
```

--------------------------------

### Get MenuItemId Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.ruiupdateui/menuitemid

Retrieves the Guid identifier for the owning menu item. This property is read-only and returns a Guid value. It is available in RhinoCommon API version 5.11 and later.

```csharp
public Guid MenuItemId {get}
```

--------------------------------

### Get Sun Panel Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/sun

Retrieves the unique identifier (Guid) for the Rhino Sun panel. This property is read-only and available since Rhino version 5.0. It is part of the Rhino.UI.PanelIds class.

```csharp
public static Guid Sun { get; }
```

--------------------------------

### Get Rhino Notes Panel GUID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/notes

Retrieves the unique identifier (Guid) for the Rhino Notes panel. This property is part of the Rhino.UI.PanelIds class and is available in RhinoCommon version 5.9 and later.

```csharp
public static Guid Notes {get}
```

--------------------------------

### FileStl Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filestl/filestl

Initializes a new instance of the FileStl class.

```APIDOC
## FileStl Constructor

### Description
Initializes a new instance of the FileStl class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "FileStl()"
}
```

### Response
#### Success Response (Instance)
- **FileStl** (Object) - An initialized instance of the FileStl class.

#### Response Example
```json
{
  "example": "// Instance created successfully"
}
```
```

--------------------------------

### Get or Set ShowIncompatibleMaterials Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.utilities/showincompatiblematerials

The ShowIncompatibleMaterials property is a static boolean that determines if incompatible content is displayed in editors. Its availability started from version 5.3. This property can be both read (get) and modified (set).

```csharp
public static bool ShowIncompatibleMaterials {get|set}
```

--------------------------------

### Rhino.Runtime.Skin.ShowHelp Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.skin/showhelp

This method is called when the 'help' splash screen should be shown. The default implementation simply calls ShowSplash().

```APIDOC
## Rhino.Runtime.Skin.ShowHelp Method

### Description
Called when the "help" splash screen should be shown. Default implementation just calls ShowSplash()

### Method
protected virtual void

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Void)
This method does not return a value.

#### Response Example
N/A
```

--------------------------------

### AnimationProperties.StartHour

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.animationproperties/starthour

Gets or sets the start hour for seasonal/one day sun animation in the range 0 to 23. Available since Rhino 6.11.

```APIDOC
## AnimationProperties.StartHour

### Description
Gets or sets the start hour for seasonal/one day sun animation in the range 0 to 23.

### Method
GET | SET

### Endpoint
Rhino.DocObjects.AnimationProperties.StartHour

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (This is a property, not an endpoint requiring a request body)

### Request Example
```json
{
  "get": "StartHour",
  "set": {
    "value": 14
  }
}
```

### Response
#### Success Response (200)
- **type** (int) - The start hour for the sun animation.

#### Response Example
```json
{
  "value": 14
}
```
```

--------------------------------

### Get Installed Plug-In Folders (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getinstalledpluginfolders

Retrieves an array of strings, where each string is a path to a folder containing an installed Rhino plug-in. This method is useful for discovering plug-in locations on the system. It has no parameters and returns all relevant folder paths.

```csharp
public static String[] GetInstalledPlugInFolders()
{
  // Implementation details omitted for brevity
  return new String[] { "C:\\Program Files\\Rhino\\PlugIns", "C:\\Users\\Public\\Documents\\Rhino\\PlugIns" };
}
```

--------------------------------

### Brep.CreateFromLoftRebuild (8.21)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfromloftrebuild

Constructs one or more Breps by lofting through a set of curves. Input for the loft is simplified by rebuilding to a specified number of control points.

```APIDOC
## Brep.CreateFromLoftRebuild

### Description
Constructs one or more Breps by lofting through a set of curves. Input for the loft is simplified by rebuilding to a specified number of control points.

### Method
`public static Brep[] CreateFromLoftRebuild(
    IEnumerable<Curve> curves,
    Point3d start,
    Point3d end,
    LoftType loftType,
    Boolean closed,
    Double angleTol,
    Int32 rebuildPointCount
)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
* **curves** (IEnumerable<Curve>) - Required - The curves to loft through. This function will not perform any curve sorting. You must pass in curves in the order you want them lofted. This function will not adjust the directions of open curves. Use Curve.DoDirectionsMatch and Curve.Reverse to adjust the directions of open curves. This function will not adjust the seams of closed curves. Use Curve.ChangeClosedCurveSeam to adjust the seam of closed curves.
* **start** (Point3d) - Optional - Optional starting point of loft. Use Point3d.Unset if you do not want to include a start point.
* **end** (Point3d) - Optional - Optional ending point of loft. Use Point3d.Unset if you do not want to include an end point.
* **loftType** (LoftType) - Required - Type of loft to perform.
* **closed** (System.Boolean) - Required - True if the last curve in this loft should be connected back to the first one.
* **angleTol** (System.Double) - Required - Angle tolerance, in radians, used to perform the loft.
* **rebuildPointCount** (System.Int32) - Required - A number of points to use while rebuilding the curves. 0 leaves turns this parameter off.

### Request Example
```json
{
  "curves": [],
  "start": null,
  "end": null,
  "loftType": null,
  "closed": false,
  "angleTol": 0.0,
  "rebuildPointCount": 0
}
```

### Response
#### Success Response (200)
* **Brep[]** - Constructs a closed surface, continuing the surface past the last curve around to the first curve. Available when you have selected three shape curves.

#### Response Example
```json
[
  {
    "example": "Brep object"
  }
]
```

Available since: 8.21
```

--------------------------------

### Set and Get Title Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3mfwriteoptions/title

The Title property of the Rhino.FileIO.File3mfWriteOptions class is used to set or get a string value representing the title. This property is available starting from version 8.7 of the RhinoCommon API.

```csharp
public string Title {get|set}
```

--------------------------------

### FileStpReadOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filestpreadoptions/filestpreadoptions

Initializes a new instance of the FileStpReadOptions class. This constructor does not take any parameters.

```APIDOC
## FileStpReadOptions()

### Description
Initializes a new instance of the FileStpReadOptions class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
FileStpReadOptions()
```

### Response
#### Success Response (200)
An initialized instance of FileStpReadOptions.

#### Response Example
```json
{
  "instance": "FileStpReadOptions"
}
```
```

--------------------------------

### Get RhinoDraftAngleAnalysisModeId Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.visualanalysismode/rhinodraftangleanalysismodeid

Retrieves the unique identifier (Guid) for Rhino's built-in draft angle analysis mode. This mode is used for visualizing draft angles using false colors. The Guid is a static property and does not require an instance of the VisualAnalysisMode class.

```csharp
System.Guid rhinoDraftAngleAnalysisModeId = Rhino.Display.VisualAnalysisMode.RhinoDraftAngleAnalysisModeId;
// The variable rhinoDraftAngleAnalysisModeId now holds the Guid for the draft angle analysis mode.
```

--------------------------------

### AnimationStart Method Signature (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.snapshots.snapshotsclient/animationstart

Defines the signature for the AnimationStart method, which is called once at the start of an animation. It requires the current Rhino document and the total number of frames.

```csharp
public abstract Void AnimationStart(
  RhinoDoc doc,
  Int32 iFrames
)
```

--------------------------------

### Get Circle Center from Closed Curves (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/examples/circlecenter

This C# example demonstrates how to get the center point of closed curves selected by the user. It uses RhinoCommon's input and geometry functions to prompt for objects, filter for closed curves, and then attempts to retrieve circle information. Dependencies include the RhinoCommon library. Input is a selection of curve objects, and output is the center point of detected circles.

```csharp
partial class Examples
{
  public static Rhino.Commands.Result CircleCenter(Rhino.RhinoDoc doc)
  {
    Rhino.Input.Custom.GetObject go = new Rhino.Input.Custom.GetObject();
    go.SetCommandPrompt("Select objects");
    go.GeometryFilter = Rhino.DocObjects.ObjectType.Curve;
    go.GeometryAttributeFilter = Rhino.Input.Custom.GeometryAttributeFilter.ClosedCurve;
    go.GetMultiple(1, 0);
    if( go.CommandResult() != Rhino.Commands.Result.Success )
      return go.CommandResult();

    Rhino.DocObjects.ObjRef[] objrefs = go.Objects();
    if( objrefs==null )
      return Rhino.Commands.Result.Nothing;

    double tolerance = doc.ModelAbsoluteTolerance;
    for( int i=0; i<objrefs.Length; i++ )
    {
      // get the curve geometry
      Rhino.Geometry.Curve curve = objrefs[i].Curve();
      if( curve==null )
        continue;
      Rhino.Geometry.Circle circle;
      if( curve.TryGetCircle(out circle, tolerance) )
      {
        Rhino.RhinoApp.WriteLine("Circle{0}: center = {1}", i+1, circle.Center);
      }
    }
    return Rhino.Commands.Result.Success;
  }
}
```

--------------------------------

### Get Rhino Executable Folder Path

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Retrieves the complete file system path to the directory where the Rhino executable is installed. This is useful for accessing resources or configuration files located within the Rhino installation.

```python
import rhinoscriptsyntax as rs

# Get the path to the Rhino executable folder
folder = rs.ExeFolder()
print(f"Rhino executable folder: {folder}")
```

--------------------------------

### SimpleArraySurfacePointer Class Documentation

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_InteropWrappers_SimpleArraySurfacePointer

Documentation for the SimpleArraySurfacePointer class, its constructor, and methods.

```APIDOC
## SimpleArraySurfacePointer Class

Wrapper for a C++ ON_SimpleArray of ON_Surface* or constant ON_Surface*. If you are not writing C++ code then this class is not for you.

### Namespace
Rhino.Runtime.InteropWrappers

### Constructors

#### SimpleArraySurfacePointer()

Initializes a new <b>SimpleArraySurfacePointer</b> instance.

### Methods

#### ConstPointer()

Gets the constant (immutable) pointer of this array.

#### Dispose()

Actively reclaims unmanaged resources that this instance uses.

#### Dispose(Boolean disposing)

For derived class implementers. This method is called with argument True when class user calls Dispose(), while with argument False when the Garbage Collector invokes the finalizer, or Finalize() method. You must reclaim all used unmanaged resources in both cases, and can use this chance to call Dispose on disposable fields if the argument is true. Also, you must call the base virtual method within your overriding method.

#### NonConstPointer()

Gets the non-constant pointer (for modification) of this array.

#### ToNonConstArray()

Copies the unmanaged array to a managed counterpart. Elements are made non-constant.
```

--------------------------------

### SetupDisplayMaterial with Transform | RhinoCommon C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaypipeline/setupdisplaymaterial

Sets up a display material using the active document, a Rhino object, its attributes, and an instance transformation. This overload is available since version 8.0 and returns a DisplayMaterial if successful, otherwise None.

```csharp
public DisplayMaterial SetupDisplayMaterial(
  RhinoDoc doc,
  RhinoObject rhinoObject,
  ObjectAttributes attributes,
  Transform instanceTransform
)
```

--------------------------------

### FileStpWriteOptions.Schema

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filestpwriteoptions/schema

Get and set the schema of the step file being written.

```APIDOC
## FileStpWriteOptions.Schema

### Description
Get and set the schema of the step file being written.

### Method
GET | SET

### Endpoint
Rhino.FileIO/FileStpWriteOptions/Schema

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
(For SET operation)
- **schema** (StepSchema) - Required - The STEP schema to set.

### Request Example
```json
{
  "schema": "AP214"
}
```

### Response
#### Success Response (200 - for GET)
- **schema** (StepSchema) - The current STEP schema configuration.

#### Response Example
```json
{
  "schema": "AP203"
}
```

### Remarks
Available since version 8.0.
```

--------------------------------

### Get Named Position Guid by Name (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.tables.namedpositiontable/id

Retrieves the unique Guid identifier for a Named Position within the Rhino document using its string name. If the Named Position is not found, an empty Guid is returned. This method is part of the Rhino.DocObjects.Tables.NamedPositionTable class and requires RhinoCommon library.

```csharp
public Guid Id(string name)
{
  // Implementation details to find the Guid by name
  // Returns Guid.Empty if not found
}
```

--------------------------------

### IZooClientUtilities - ReturnLicense Method (Overload 1)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.izooclientutilities/returnlicense

This overload of the ReturnLicense method verifies and returns a license using an Object and a Guid.

```APIDOC
## ReturnLicense (Overload 1)

### Description
Verifies and returns a license using an Object and a Guid.

### Method
Protected (implied, as not explicitly public)

### Endpoint
N/A (This is a method within a class, not a REST API endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "verify": "object_value",
  "productId": "00000000-0000-0000-0000-000000000000"
}
```

### Response
#### Success Response (Boolean)
- **return_value** (Boolean) - True if the license was successfully returned, false otherwise.

#### Response Example
```json
{
  "return_value": true
}
```

### Available Since
6.0
```

--------------------------------

### Load Installed Plug-in (basic)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/loadplugin

Loads an installed plug-in using its unique identifier. This is a simpler overload that does not provide options for quiet loading or forcing the load. It returns a boolean indicating success.

```csharp
public static Boolean LoadPlugIn(
  Guid pluginId
)
```

--------------------------------

### GetPanels (Guid, RhinoDoc)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panels/getpanels

Gets the panels associated with a specific panel ID and document.

```APIDOC
## GetPanels (Guid, RhinoDoc)

### Description
Gets the panels.

### Method
GET (Assumed, as no method is specified, and it retrieves data)

### Endpoint
/Rhino.UI/Panels/GetPanels

### Parameters
#### Path Parameters
None

#### Query Parameters
- **panelId** (System.Guid) - Required - Panel identifier.
- **doc** (RhinoDoc) - Required - The document.

### Request Example
```json
{
  "panelId": "<guid>",
  "doc": "<rhinoDoc>"
}
```

### Response
#### Success Response (200)
- **object** - The panels.

#### Response Example
```json
{
  "panels": "<object>"
}
```

### Available since
6.3
```

--------------------------------

### HistorySettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.historysettings/historysettings

Initializes a new instance of the HistorySettings class.

```APIDOC
## HistorySettings()

### Description
Initializes a new instance of the HistorySettings class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "Not applicable for constructors"
}
```

### Response
#### Success Response (N/A)
- N/A

#### Response Example
```json
{
  "example": "Not applicable for constructors"
}
```
```

--------------------------------

### GET /Rhino.UI/PanelIds/Display

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/display

Retrieves the unique Guid identifier for the Rhino Display Properties panel.

```APIDOC
## GET /Rhino.UI/PanelIds/Display

### Description
Retrieves the unique Guid identifier for the Rhino Display Properties panel.

### Method
GET

### Endpoint
/Rhino.UI/PanelIds/Display

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Guid** (System.Guid) - The unique identifier for the Display Properties panel.

#### Response Example
{
  "example": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

--------------------------------

### Utilities Methods

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render

This section details the various methods available in the Utilities class for managing render content, files, and UI elements.

```APIDOC
## Utilities Methods

### ChangeContentType
#### Description
Changes the type of a content. This deletes the content and creates a replacement of the specified type allowing the caller to decide about harvesting.

### FindFile (overload 1)
#### Description
Finds a file and also handles network shares. This is a replacement for CRhinoFileUtilities::FindFile().

### FindFile (overload 2)
#### Description
Finds a file and also handles network shares. This is a replacement for CRhinoFileUtilities::FindFile().

### GetUnpackedFilesCacheFolder
#### Description
Gets a folder associated with the document for unpacking textures to.

### IsCachedTextureFileInUse
#### Description
Determines if any texture in any persistent content list is using the specified file name for caching.

### LoadPersistentRenderContentFromFile
#### Description
Loads a content from a library file and adds it to the persistent content list of a particular document.

### MoveWindow
#### Description
Moves a window to a specified rectangle.

### PromptForSaveImageFileParameters
#### Description
Prompts the user for a save file name and the width, height and depth of an image to be saved.

### SafeFrameEnabled
#### Description
Queries whether or not the Safe Frame is visible.

### SetDefaultRenderPlugIn
#### Description
Set default render application.

### ShowContentChooser (overload 1)
#### Description
Shows the content chooser to allow the user to select a new or existing content, or multiple contents.

### ShowContentChooser (overload 2)
#### Description
Shows the content chooser to allow the user to select a new or existing content, or multiple contents.

### ShowContentChooser (overload 3)
#### Description
Shows the content chooser to allow the user to select a new or existing content.

### ShowIORMenu
#### Description
Display and track the context menu.
```

--------------------------------

### RefineAngleInDegrees Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.meshingparameters/refineangleindegrees

Gets or sets the mesh parameter refine angle in degrees. This property is available starting from version 8.0.

```APIDOC
## RefineAngleInDegrees Property

### Description
Gets or sets the mesh parameter refine angle in degrees.

### Method
Get/Set

### Endpoint
Rhino.Geometry.MeshingParameters.RefineAngleInDegrees

### Parameters

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "Not applicable for property access"
}
```

### Response
#### Success Response (200)
- **Value** (double) - The mesh refine angle in degrees.

#### Response Example
```json
{
  "example": "30.0"
}
```

### Remarks
Available since version 8.0.
```

--------------------------------

### VerifyLicenseKey Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime

Details on how to verify a license key using the ZooClient.

```APIDOC
## POST /api/verifyLicenseKey

### Description

Called by GetLicense to ensure that the license key entered by the user is legitimate and can be used.

### Method
POST

### Endpoint
`/api/verifyLicenseKey`

### Parameters

#### Query Parameters

*   **licenseKey** (string) - Required - The license key provided by the user.
*   **validationCode** (string) - Required - The validation code associated with the license.
*   **validationCodeInstallDate** (DateTime) - Required - The installation date of the validation code.
*   **gracePeriodExpired** (boolean) - Required - Indicates if the grace period has expired.

#### Request Body

None

### Response

#### Success Response (200)

*   **licenseData** (LicenseData) - Contains detailed information about the validated license.

#### Error Response (e.g., 400, 401, 500)

*   **message** (string) - A descriptive error message.

### Request Example

```json
{
  "licenseKey": "YOUR_LICENSE_KEY",
  "validationCode": "VALIDATION_CODE",
  "validationCodeInstallDate": "2023-01-01T10:00:00Z",
  "gracePeriodExpired": false
}
```

### Response Example (Success)

```json
{
  "licenseData": {
    "isValid": true,
    "message": "License verified successfully."
    // ... other license data fields
  }
}
```
```

--------------------------------

### GetInstalledPlugInNames (With Filters - 5.0+)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getinstalledpluginnames

Gets a list of installed plug-in names, restricted by type and load status.

```APIDOC
## GET /api/Rhino.PlugIns/PlugIn/GetInstalledPlugInNames

### Description
Gets a list of installed plug-in names. The list can be restricted by some filters.

### Method
GET

### Endpoint
/api/Rhino.PlugIns/PlugIn/GetInstalledPlugInNames

### Parameters
#### Query Parameters
- **typeFilter** (PlugInType) - Required - The enumeration flags that determine which types of plug-ins are included.
- **loaded** (Boolean) - Required - True if loaded plug-ins are returned.
- **unloaded** (Boolean) - Required - True if unloaded plug-ins are returned.

### Request Example
```json
{
  "typeFilter": "Application",
  "loaded": true,
  "unloaded": false
}
```

### Response
#### Success Response (200)
- **String[]** - An array of installed plug-in names. This can be empty, but not null.

#### Response Example
```json
{
  "pluginNames": [
    "PluginA",
    "PluginB"
  ]
}
```
```

--------------------------------

### Get ExposureTextureType Guid - C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/exposuretexturetype

Retrieves the Guid for the ExposureTextureType. This is a static read-only property available since RhinoCommon version 6.0. It is used to identify the exposure texture type within the Rhino.Render namespace.

```csharp
public static Guid ExposureTextureType { get; }
```

--------------------------------

### Get Layer Identifier by Name

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

This script shows how to obtain the unique identifier (GUID) of a layer given its name. It utilizes the rhinoscriptsyntax library and returns the GUID as a string or None if the layer is not found or an error occurs.

```python
import rhinoscriptsyntax as rs

id = rs.LayerId('Layer 01')
```

--------------------------------

### LightManagerSupportClient Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.lightmanagersupportclient/lightmanagersupportclient

Initializes a new instance of the LightManagerSupportClient class.

```APIDOC
## LightManagerSupportClient constructor

### Description
Initializes a new instance of the LightManagerSupportClient class.

### Method
Constructor

### Endpoint
N/A (Constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
public LightManagerSupportClient(uint doc_uuid)
```

### Response
#### Success Response (N/A for constructors)
N/A

#### Response Example
N/A
```

--------------------------------

### AnimationProperties.StartSeconds

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.animationproperties/startseconds

Gets or sets the start seconds for seasonal/one day sun animation in the range 0 to 59.

```APIDOC
## Rhino.DocObjects.AnimationProperties.StartSeconds

### Description
Gets or sets the start seconds for seasonal/one day sun animation in the range 0 to 59.

### Method
Get or Set

### Endpoint
Rhino.DocObjects.AnimationProperties.StartSeconds

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "Not applicable for property"
}
```

### Response
#### Success Response (200)
- **int** - The start seconds for sun animation (0-59).

#### Response Example
```json
{
  "example": "15"
}
```
```

--------------------------------

### Get Rhino Installation Folder (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.filesettings/installfolder

Retrieves the installation directory of Rhino using the static InstallFolder property. This property returns a DirectoryInfo object representing the path. It is available since Rhino version 5.0.

```csharp
using Rhino.ApplicationSettings;

// Get the installation folder
DirectoryInfo installDir = FileSettings.InstallFolder;

// You can then use the path, for example:
Console.WriteLine("Rhino installation path: " + installDir.FullName);

```

--------------------------------

### Get Layer Per-Viewport Color (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.layer/perviewportcolor

Retrieves the display color of a layer for a specified viewport. If an empty Guid is provided, it may return a default or general setting. Requires a valid Guid for the viewport.

```csharp
using System;
using System.Drawing;

// Assuming 'layer' is an instance of Rhino.DocObjects.Layer
// and 'viewportId' is a System.Guid representing the viewport
Color color = layer.PerViewportColor(viewportId);
```

--------------------------------

### Access Rhino Layer Panel Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/layers

Retrieves the unique identifier (Guid) for the Rhino Layer panel using the Rhino.UI.PanelIds class. This property is static and read-only. It is available starting from Rhino version 5.0.

```csharp
public static Guid Layers {get}
```

--------------------------------

### Vector2d Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Vector2d

Details on how to initialize a Vector2d object.

```APIDOC
## Vector2d Constructor

### Description
Initializes a new instance of the vector based on two, X and Y, components.

### Method
Constructor

### Parameters
* **x** (double) - The X component of the vector.
* **y** (double) - The Y component of the vector.

### Request Example
```csharp
Vector2d myVector = new Vector2d(1.0, 2.0);
```

### Response
#### Success Response (200)
Represents a successfully initialized Vector2d object.

#### Response Example
```json
{
  "x": 1.0,
  "y": 2.0
}
```
```

--------------------------------

### Create Brep from Revolution Surface

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Brep

Constructs a Brep from a surface of revolution.

```APIDOC
## POST /websites/developer_rhino3d_api/brep

### Description
Constructs a brep form of a surface of revolution.

### Method
POST

### Endpoint
/websites/developer_rhino3d_api/brep/from-rev-surface

### Parameters
#### Request Body
- **surface** (object) - Required - The surface of revolution.
- **capStart** (boolean) - Required - Whether to cap the start of the surface.
- **capEnd** (boolean) - Required - Whether to cap the end of the surface.
```

--------------------------------

### Get and Set Spotlight HotSpot (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.light/hotspot

This C# example demonstrates how to get and set the HotSpot property for a spotlight in Rhino.Geometry. The HotSpot is a double value between 0.0 and 1.0 that controls the spotlight's focus.

```csharp
public double HotSpot { get; set; }
```

--------------------------------

### Create Brep from Surface

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Brep

Constructs a Brep from a surface with a boundary defined by four trims.

```APIDOC
## POST /websites/developer_rhino3d_api/brep

### Description
Constructs a Brep from a surface. The resulting Brep has an outer boundary made from four trims. The trims are ordered so that they run along the south, east, north, and then west side of the surface's parameter space.

### Method
POST

### Endpoint
/websites/developer_rhino3d_api/brep/from-surface

### Parameters
#### Request Body
- **surface** (object) - Required - The input surface.
```

--------------------------------

### Rhino.Render.RenderContentType.Id

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendercontenttype/id

Gets the type identifier associated with this type. This property returns a Guid representing the unique ID of the render content type.

```APIDOC
## Rhino.Render.RenderContentType.Id

### Description
Returns the type identifier associated with this type.

### Method
GET

### Endpoint
Rhino.Render.RenderContentType.Id

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
This is a property, not an endpoint requiring a request body.

### Response
#### Success Response (200)
- **Id** (Guid) - The type identifier associated with this type.

#### Response Example
```json
{
  "Id": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```
```

--------------------------------

### ShowPopupMenu Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.irhinouidialogservice/showpopupmenu

The ShowPopupMenu method displays a context menu with the specified items at a given screen location.

```APIDOC
## ShowPopupMenu

### Description
Displays a context menu with the provided items at the specified screen coordinates.

### Method
`Int32 ShowPopupMenu(
  String[] arrItems,
  Int32[] arrModes,
  Int32? screenPointX,
  Int32? screenPointY
)`

### Class
Rhino.UI.IRhinoUiDialogService

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
*   **arrItems** (String[]) - Required - An array of strings representing the items to display in the menu.
*   **arrModes** (Int32[]) - Required - An array of integers representing the modes for each menu item.
*   **screenPointX** (Int32?) - Optional - The X-coordinate on the screen where the menu should be displayed.
*   **screenPointY** (Int32?) - Optional - The Y-coordinate on the screen where the menu should be displayed.

### Request Example
```json
{
  "arrItems": ["Item 1", "Item 2"],
  "arrModes": [0, 1],
  "screenPointX": 100,
  "screenPointY": 200
}
```

### Response
#### Success Response (200)
*   **Type**: Int32 - The result of the menu interaction (e.g., the index of the selected item).

#### Response Example
```json
{
  "result": 0
}
```
```

--------------------------------

### GetCachedTextureCoordinates (Guid)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.mesh/getcachedtexturecoordinates

Call this method to get cached texture coordinates for a texture mapping with the specified Id.

```APIDOC
## GetCachedTextureCoordinates (Guid)

### Description
Call this method to get cached texture coordinates for a texture mapping with the specified Id.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Geometry/Mesh/GetCachedTextureCoordinates

### Parameters
#### Path Parameters
- **textureMappingId** (System.Guid) - Required - Texture mapping Id

### Response
#### Success Response (200)
- **CachedTextureCoordinates** (CachedTextureCoordinates) - Object which allows access to coordinates and other props.

### Details
Available since: 5.10
```

--------------------------------

### Get Rendering Start Time in Milliseconds (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectpipeline/getstarttimeinmilliseconds

Retrieves the start time of the rendering process in milliseconds since an unspecified epoch. This method is part of the Rhino.Render.PostEffects.PostEffectPipeline class and is available from Rhino version 7.0 onwards. The returned value is of type UInt64.

```csharp
public UInt64 GetStartTimeInMilliseconds()
{
  // Implementation details for retrieving the start time in milliseconds.
  // This is a placeholder and would contain the actual logic.
  return 0; // Example return value
}
```

--------------------------------

### GetInstalledPlugInNames (With Filters - 7.5+)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getinstalledpluginnames

Gets a list of installed plug-in names, restricted by type, load status, and localization.

```APIDOC
## GET /api/Rhino.PlugIns/PlugIn/GetInstalledPlugInNames

### Description
Gets a list of installed plug-in names. The list can be restricted by some filters.

### Method
GET

### Endpoint
/api/Rhino.PlugIns/PlugIn/GetInstalledPlugInNames

### Parameters
#### Query Parameters
- **typeFilter** (PlugInType) - Required - The enumeration flags that determine which types of plug-ins are included.
- **loaded** (Boolean) - Required - True if loaded plug-ins are returned.
- **unloaded** (Boolean) - Required - True if unloaded plug-ins are returned.
- **localizedPlugInName** (Boolean) - Required - If True localized plug-in names are returned, otherwise English names are returned.

### Request Example
```json
{
  "typeFilter": "Application",
  "loaded": true,
  "unloaded": false,
  "localizedPlugInName": true
}
```

### Response
#### Success Response (200)
- **String[]** - An array of installed plug-in names. This can be empty, but not null.

#### Response Example
```json
{
  "pluginNames": [
    "LocalizedPluginName1",
    "LocalizedPluginName2"
  ]
}
```
```

--------------------------------

### DecalCreateParams.StartLatitude Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.decalcreateparams/startlatitude

The StartLatitude property of the DecalCreateParams class in the Rhino.Render namespace. It allows getting and setting the starting latitude for decal creation.

```APIDOC
## DecalCreateParams.StartLatitude Property

### Description
Gets or sets the starting latitude for decal creation.

### Class
Rhino.Render.DecalCreateParams

### Syntax
```csharp
public double StartLatitude { get; set; }
```

### Returns
Type: `double`

### Available since
6.0
```

--------------------------------

### CurvatureAnalysisSettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.curvatureanalysissettings/curvatureanalysissettings

Initializes a new instance of the CurvatureAnalysisSettings class.

```APIDOC
## CurvatureAnalysisSettings()

### Description
Initializes a new instance of the CurvatureAnalysisSettings class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "No request body needed for constructor."
}
```

### Response
#### Success Response (Instance Created)
- **CurvatureAnalysisSettings** (object) - An instance of the CurvatureAnalysisSettings class.

#### Response Example
```json
{
  "example": "Instance of CurvatureAnalysisSettings"
}
```
```

--------------------------------

### Transform.M10 Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.transform/m10

Gets or sets the M10 value of the Transform matrix. This property is of type double and was available starting from version 5.0.

```APIDOC
## Transform.M10 Property

### Description
Gets or sets the M10 value of the Transform matrix.

### Method
Get/Set

### Endpoint
N/A (Class Property)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None (This is a property, not an endpoint with a request body)

### Request Example
```csharp
// To get the value
double m10Value = transformInstance.M10;

// To set the value
transformInstance.M10 = someDoubleValue;
```

### Response
#### Success Response (200)
N/A (Property access, not an HTTP response)

#### Response Example
```json
{
  "value": 1.2345  // Example of a double value
}
```

### Remarks
Available since RhinoCommon version 5.0.
```

--------------------------------

### Rhino.RhinoDoc.GetGridDefaults()

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinodoc/getgriddefaults

Retrieves the default grid settings for the construction plane.

```APIDOC
## Rhino.RhinoDoc.GetGridDefaults()

### Description
Retrieves the default grid settings for the construction plane.

### Method
public ConstructionPlaneGridDefaults GetGridDefaults()

### Endpoint
N/A (This is a method call within the RhinoCommon API, not a REST endpoint)

### Parameters
This method does not accept any parameters.

### Request Example
```csharp
// Example usage within a RhinoCommon plugin or script
Rhino.RhinoDoc doc = Rhino.RhinoDoc.ActiveDoc;
ConstructionPlaneGridDefaults gridDefaults = doc.GetGridDefaults();
// Use gridDefaults object here
```

### Response
#### Success Response
- **Type**: ConstructionPlaneGridDefaults - An object containing the default grid settings.

#### Response Example
```json
{
  "example": "ConstructionPlaneGridDefaults object representing default grid settings"
}
```

### Availability
Available since: 8.13
```

--------------------------------

### Rhino.Geometry.LinearDimension.DimensionLinePoint

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.lineardimension/dimensionlinepoint

Gets or sets the point on the annotation plane where the dimension line starts. This property is of type Point2d and was introduced in version 6.0.

```APIDOC
## Rhino.Geometry.LinearDimension.DimensionLinePoint

### Description
Gets or sets the point on the annotation plane where the dimension line starts.

### Method
Get/Set

### Endpoint
N/A (Property within a class)

### Parameters
None

### Request Example
N/A (Property access)

### Response
#### Success Response (200)
- **DimensionLinePoint** (Point2d) - The point on the annotation plane where the dimension line starts.

#### Response Example
```json
{
  "DimensionLinePoint": {
    "X": 10.0,
    "Y": 5.0
  }
}
```

### Available since
6.0
```

--------------------------------

### Rhino.DocObjects.AnimationProperties.StartDay

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.animationproperties/startday

Gets or sets the start day for seasonal/one day sun animation in the range 1 to 31.

```APIDOC
## Rhino.DocObjects.AnimationProperties.StartDay

### Description
Gets or sets the start day for seasonal/one day sun animation in the range 1 to 31.

### Method
GET | SET

### Endpoint
Not Applicable (Property)

### Parameters

#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// To get the start day
int startDay = animationProperties.StartDay;

// To set the start day
animationProperties.StartDay = 15;
```

### Response
#### Success Response (200)
- **int**: The start day for the sun animation.

#### Response Example
```json
15
```
```

--------------------------------

### ShowDialog Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.openfiledialog/showdialog

Displays the file open dialog. This method is deprecated and ShowOpenDialog should be used instead.

```APIDOC
## ShowDialog Method

### Description
Displays the file open dialog. This method is deprecated and ShowOpenDialog should be used instead.

### Method
`public DialogResult ShowDialog()`

### Endpoint
Rhino.UI.OpenFileDialog.ShowDialog

### Parameters
This method does not accept any parameters.

### Request Example
```
// No request body for this method
```

### Response
#### Success Response (DialogResult)
- **DialogResult** (DialogResult) - Indicates how the user closed the dialog box. Can be one of the DialogResult enum values (e.g., OK, Cancel).

#### Response Example
```json
{
  "result": "OK"
}
```

### Remarks
- **Deprecated in version**: 6.0
- **Obsolete**: Use `ShowOpenDialog` instead.
- **Available since**: 5.0
```

--------------------------------

### IntersectionEvent.ParameterA

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.intersect.intersectionevent/parametera

Gets the parameter on Curve A where the intersection occurred. If the intersection type is overlap, then this will return the start of the overlap region.

```APIDOC
## IntersectionEvent.ParameterA

### Description
Gets the parameter on Curve A where the intersection occurred. If the intersection type is overlap, then this will return the start of the overlap region.

### Method
Get

### Endpoint
Rhino.Geometry.Intersect.IntersectionEvent.ParameterA

### Parameters
None

### Response
#### Success Response (200)
- **ParameterA** (double) - The parameter on Curve A where the intersection occurred.

#### Response Example
```json
{
  "ParameterA": 0.5
}
```
```

--------------------------------

### FileTxt Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filetxt/filetxt

Initializes a new instance of the FileTxt class. This is a fundamental operation for creating and managing text-based file interactions within the Rhino ecosystem.

```APIDOC
## FileTxt Constructor

### Description
Initializes a new instance of the FileTxt class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{
  "example": "FileTxt()"
}
```

### Response
#### Success Response (Instance Created)
- **Instance** (FileTxt) - A new instance of the FileTxt class.

#### Response Example
```json
{
  "example": "// In C#\nFileTxt myFileTxt = new FileTxt();"
}
```
```

--------------------------------

### Rhino.FileIO.FileDwgReadOptions.LayoutUnits

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filedwgreadoptions/layoutunits

This property allows you to get or set the UnitSystem for layout units when reading DWG files. It is available starting from version 8.0.

```APIDOC
## Rhino.FileIO.FileDwgReadOptions.LayoutUnits

### Description
Gets or sets the UnitSystem for layout units when reading DWG files.

### Method
`get` or `set`

### Endpoint
N/A (This is a property within a class)

### Parameters
**None for the property itself.**

### Request Example
(Property access, not an HTTP request)
```csharp
// Get the layout units
UnitSystem currentLayoutUnits = dwgReadOptions.LayoutUnits;

// Set the layout units
dwgReadOptions.LayoutUnits = UnitSystem.Inches;
```

### Response
#### Success Response
- **UnitSystem** (Type: Enum) - The current unit system for layout units.
```

--------------------------------

### Silhouette Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.silhouette/silhouette

Initializes a new instance of the Silhouette class.

```APIDOC
## Silhouette constructor

### Description
Initializes a new instance of the Silhouette class.

### Method
constructor

### Endpoint
N/A (Class constructor)

### Parameters
None

### Request Example
```json
{}
```

### Response
#### Success Response (N/A)
N/A

#### Response Example
```json
"// Represents a Silhouette object"
```
```

--------------------------------

### Get Guid Without Default Value (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.collections.archivabledictionary/getguid

Retrieves a Guid value associated with a given key. This method will only succeed if the value was originally set using Set(string key, Guid value). If the key does not exist or was not set in this manner, the operation will fail. Available since version 5.0.

```csharp
public Guid GetGuid(
  String key
)
```

--------------------------------

### FileSlc Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileslc/fileslc

Initializes a new instance of the FileSlc class.

```APIDOC
## FileSlc Constructor

### Description
Initializes a new instance of the FileSlc class.

### Method
CONSTRUCTOR

### Endpoint
Rhino.FileIO.FileSlc

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{
  "example": "FileSlc()"
}
```

### Response
#### Success Response (200)
This is a constructor, so it returns an initialized instance of the FileSlc class.

#### Response Example
```json
{
  "example": "Initialized FileSlc object"
}
```
```

--------------------------------

### SetLightSolo Method - C# Example

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.lightmanagersupport/setlightsolo

Demonstrates how to use the SetLightSolo method to manage light solo mode. This method takes a RhinoDoc, a light's GUID, and a boolean to indicate solo mode status. It returns a boolean indicating success.

```csharp
public virtual Boolean SetLightSolo(
  RhinoDoc doc,
  Guid uuid_light,
  Boolean bSolo
)
```

--------------------------------

### HostUtils.LoadAssemblyFrom

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/loadassemblyfrom

Loads an assembly from a given file path. This method is part of the Rhino.Runtime.HostUtils class and is available from version 8.0 onwards.

```APIDOC
## LoadAssemblyFrom Method

### Description
Calls Assembly.LoadFrom in .NET 4.8. May call a different routine under .NET Core.

### Method
`public static Assembly LoadAssemblyFrom(String path)`

### Endpoint
Rhino.Runtime.HostUtils

### Parameters
#### Path Parameters
- **path** (String) - Required - The full path to the assembly file to load.

### Request Body
This method does not accept a request body.

### Response
#### Success Response (200)
- **Assembly** (Type: `System.Reflection.Assembly`) - The loaded assembly object.

#### Response Example
```json
{
  "@type": "System.Reflection.Assembly",
  "Location": "/path/to/your/assembly.dll"
}
```

### Remarks
Available since: 8.0
```

--------------------------------

### FileIO.FileLwoWriteOptions.ToDictionary

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filelwowriteoptions/todictionary

This method creates a dictionary of the current export options, which can then be passed to the RhinoDoc.Export function.

```APIDOC
## FileIO.FileLwoWriteOptions.ToDictionary

### Description
Creates a dictionary of these options. This dictionary can be passed to the RhinoDoc.Export function.

### Method
`public ArchivableDictionary ToDictionary()`

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Return Value)
- **ArchivableDictionary** - A dictionary containing the export options.

### Response Example
```json
{
  "dictionary": {
    "option1": "value1",
    "option2": "value2"
  }
}
```
```

--------------------------------

### GET /websites/developer_rhino3d_api/Rhino.Render/RenderWindow/Channel/Id

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderwindow.channel/id

Retrieves the unique identifier (GUID) of a render channel within the Rhino RenderWindow.

```APIDOC
## GET /websites/developer_rhino3d_api/Rhino.Render/RenderWindow/Channel/Id

### Description
Returns the unique channel identifier (GUID) for a render channel.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Render/RenderWindow/Channel/Id

### Parameters
This endpoint does not have any path, query, or request body parameters.

### Request Example
This endpoint does not require a request body.

### Response
#### Success Response (200)
- **Id** (Guid) - The unique identifier for the render channel.

#### Response Example
{
  "Id": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

--------------------------------

### Panels Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panels/panels

Initializes a new instance of the Panels class.

```APIDOC
## Panels constructor

### Description
Initializes a new instance of the Panels class.

### Method
Panels()

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "No request body needed for constructor"
}
```

### Response
#### Success Response (200)
- **Panels** (object) - An instance of the Panels class.

#### Response Example
```json
{
  "example": "// Code example to instantiate Panels would go here"
}
```
```

--------------------------------

### Rhino.Render.ChangeQueue.ChangeQueue.CrcFromGuid

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.changequeue.changequeue/crcfromguid

A helper function to get a CRC (Cyclic Redundancy Check) from a GUID (Globally Unique Identifier).

```APIDOC
## CrcFromGuid method

### Description
Helper function to get a CRC from a Guid.

### Method
public static UInt32 CrcFromGuid( Guid guid )

### Endpoint
N/A (This is a static method within a class, not a REST endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "guid": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

### Response
#### Success Response (200)
- **crc** (UInt32) - The CRC value generated from the GUID.

#### Response Example
```json
{
  "crc": 1234567890
}
```

### Remarks
- Available since version 6.0.
- Part of the Rhino.Render.ChangeQueue.ChangeQueue class.
```

--------------------------------

### JoinBreps - Multiple Overloads

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Brep

Joins Breps in an input array at overlapping edges to form fewer resulting Breps. Multiple overloads exist with varying parameters for tolerance and angle tolerance.

```APIDOC
## JoinBreps

### Description
Joins the breps in the input array at any overlapping edges to form as few as possible resulting breps. There may be more than one brep in the result array.

### Method
Various (details depend on overload)

### Endpoints
- `/JoinBreps(IEnumerable<Brep> brepsToJoin, Double tolerance, Double angleTolerance, out List<int[]> indexMap)`
- `/JoinBreps(IEnumerable<Brep> brepsToJoin, Double tolerance, Double angleTolerance)`
- `/JoinBreps(IEnumerable<Brep> brepsToJoin, Double tolerance)`

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **brepsToJoin** (IEnumerable<Brep>) - Required - The array of Breps to join.
- **tolerance** (Double) - Required - The tolerance for joining.
- **angleTolerance** (Double) - Optional - The angle tolerance for joining.
- **indexMap** (out List<int[]>) - Output parameter for index mapping (in the overload that includes it).

### Request Example
```json
{
  "brepsToJoin": [
    {
      "brep_data": "..."
    }
  ],
  "tolerance": 0.01,
  "angleTolerance": 0.1
}
```

### Response
#### Success Response (200)
- **result** (List<Brep>) - A list of the resulting Breps after joining.
- **indexMap** (List<int[]>) - Output parameter containing mapping information (in the overload that includes it).

#### Response Example
```json
{
  "result": [
    {
      "brep_data": "..."
    }
  ],
  "indexMap": [
    [0, 1],
    [2, 3]
  ]
}
```
```

--------------------------------

### Triangle3d.MedianB Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.triangle3d/medianb

Gets the median line of a Triangle3d starting at corner B. This property is read-only and was introduced in version 7.1.

```APIDOC
## Triangle3d.MedianB Property

### Description
Gets the median line starting at corner B.

### Method
GET

### Endpoint
`/websites/developer_rhino3d_api/Rhino.Geometry/Triangle3d/MedianB`

### Parameters
This property does not take any parameters.

### Request Example
This is a property getter and does not have a request body.

### Response
#### Success Response (200)
- **Line** (Line) - The median line starting at corner B.

#### Response Example
```json
{
  "x": 0.0,
  "y": 0.0,
  "z": 0.0,
  "direction": {
    "dx": 1.0,
    "dy": 0.0,
    "dz": 0.0
  },
  "length": 1.0
}
```
```

--------------------------------

### Create Brep from Curves (Loft) with Angle Tolerance (RhinoCommon C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfromloft

Constructs one or more Breps by lofting through a set of curves, with an option to specify an angle tolerance. Curves must be pre-sorted and their directions/seams adjusted if necessary. Supports optional start and end points.

```csharp
public static Brep[] CreateFromLoft(
  IEnumerable<Curve> curves,
  Point3d start,
  Point3d end,
  LoftType loftType,
  Boolean closed,
  Double angleTol
)
```

--------------------------------

### Triangle3d.AltitudeC

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.triangle3d/altitudec

Gets the altitude line of a Triangle3d starting at corner C. This property is available since RhinoCommon version 7.1.

```APIDOC
## Triangle3d.AltitudeC

### Description
Gets the altitude line starting at corner C.

### Method
GET

### Endpoint
Rhino.Geometry.Triangle3d.AltitudeC

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **AltitudeC** (Line) - The altitude line starting at corner C.

#### Response Example
```json
{
  "AltitudeC": {
    "From": {"X": 0.0, "Y": 0.0, "Z": 0.0},
    "To": {"X": 1.0, "Y": 1.0, "Z": 1.0}
  }
}
```
```

--------------------------------

### Brep Class Overview

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Brep

Provides information about the Brep class, its inheritance hierarchy, and related components.

```APIDOC
## Brep Class

Boundary Representation. A surface or polysurface along with trim curve information.

**Inheritance:** Rhino.Runtime.CommonObject -> Rhino.Geometry.GeometryBase -> Brep

**Namespace:** Rhino.Geometry

### Constructors

*   **Brep()**: Initializes a new empty brep.
*   **Brep(SerializationInfo info, StreamingContext context)**: Protected constructor used in serialization.

### Properties

*   **Curves2D**: Parameter space trimming curves (used by trims).
*   **Curves3D**: Pointers to 3d curves (used by edges).
*   **Disposed**: Indicates if this object has been disposed or the document it originally belonged to has been disposed.
*   **Edges**: Gets the brep edges list accessor.
*   **Faces**: Gets the brep faces list accessor.
*   **HasBrepForm**: Returns True if the Brep.TryConvertBrep function will be successful for this object.
*   **HasRegionTopology**: Returns True if the Brep has region topology information, False otherwise.
*   **HasUserData**: Gets True if this class has any custom information attached to it through UserData.
*   **IsDeformable**: True if object can be accurately modified with "squishy" transformations like projections, shears, and non-uniform scaling.
*   **IsDocumentControlled**: If True this object may not be modified. Any properties or functions that attempt to modify this object when it is set to "IsReadOnly" will throw a NotSupportedException.
*   **IsManifold**: Gets a value indicating whether or not the Brep is manifold. Non manifold breps have at least one edge that is shared among three or more faces.
*   **IsSolid**: Determines whether this brep is a solid, or a closed oriented manifold.
*   **IsSurface**: Returns True if the Brep has a single face and that face is geometrically the same as the underlying surface.
*   **IsValid**: Tests an object to see if it is valid.
*   **Loops**: Gets the brep loop list accessor.
*   **ObjectType**: Useful for switch statements that need to differentiate between basic object types like points, curves, surfaces, and so on.
*   **PerformCorruptionTesting**: Used to test ON_Object* pointers to see if they are a brep or mesh that is corrupt enough to crash Rhino.
*   **SolidOrientation**: Gets the solid orientation state of this Brep.
*   **Surfaces**: Parametric surfaces used by faces.
*   **Trims**: Gets the brep trims list accessor.
*   **UserData**: List of custom information that is attached to this class.
*   **UserDictionary**: Dictionary of custom information attached to this class.
*   **UserStringCount**: Gets the amount of user strings.
*   **Vertices**: Gets the brep vertices list accessor.

### Methods

*   **AddEdgeCurve(Curve curve)**: Add a 3d curve used by the brep edges.
*   **AddSurface(Surface surface)**: Adds a 3D surface used by BrepFace.
*   **AddTrimCurve(Curve curve)**: Add a 2d curve used by the brep trims.
*   **Append(Brep other)**: Appends a copy of another brep to this and updates indices of appended brep parts. Duplicates are not removed.
*   **CapPlanarHoles(Double tolerance)**: Returns a new Brep that is equivalent to this Brep with all planar holes capped.
*   **ChangeSeam(BrepFace face, Int32 direction, Double parameter, Double tolerance)**: Change the seam of a closed trimmed surface.
*   **ClosestPoint(Point3d testPoint, out Point3d closestPoint, out ComponentIndex ci, Double s, Double t, Double maximumDistance, out Vector3d normal)**: Finds a point on the Brep that is closest to testPoint.
*   **ClosestPoint(Point3d testPoint)**: Finds a point on the brep that is closest to testPoint.
*   **Compact()**: Compacts the brep.
```

--------------------------------

### Rhino.FileIO.File3dmRenderTexture.ToTexture

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmrendertexture/totexture

Gets a simulated texture that approximates this texture's appearance. This method is available starting from version 8.0.

```APIDOC
## Rhino.FileIO.File3dmRenderTexture.ToTexture

### Description
Gets a simulated texture that approximates this texture's appearance.

### Method
public Texture ToTexture()

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Texture)
- **Type**: Texture
- **Description**: A simulated texture object.

#### Response Example
```json
{
  "texture": "simulated_texture_object"
}
```

### Remarks
Available since: 8.0
```

--------------------------------

### Rhino.UI.RuiUpdateUi - RegisterMenuItem (Guid overload)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.ruiupdateui/registermenuitem

Registers a menu item update delegate using Guid identifiers for file, menu, and item.

```APIDOC
## POST /websites/developer_rhino3d_api/Rhino.UI/RuiUpdateUi/RegisterMenuItem

### Description
Registers a menu item update delegate using Guid identifiers.

### Method
POST

### Endpoint
/websites/developer_rhino3d_api/Rhino.UI/RuiUpdateUi/RegisterMenuItem

### Parameters
#### Query Parameters
- **file** (System.Guid) - Required - Menu file Id
- **menu** (System.Guid) - Required - Menu Id
- **item** (System.Guid) - Required - Menu item Id
- **callBack** (UpdateMenuItemEventHandler) - Required - Callback function to handle menu item updates

### Request Body
(This endpoint does not have a request body)

### Response
#### Success Response (200)
- **Boolean** - True if Registered otherwise false

#### Response Example
```json
{
  "success": true
}
```
```

--------------------------------

### ProjectToBrep (IEnumerable<Curve>, IEnumerable<Brep>, Vector3d, Double, Boolean, out Int32[], out Int32[])

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.curve/projecttobrep

Projects a collection of Curves onto a collection of Breps along a given direction, with an option for loose projection.

```APIDOC
## POST /api/curves/projectToBrep/multipleCurvesMultipleBrepsLoose

### Description
Projects a collection of Curves onto a collection of Breps along a given direction. If true, then project curve edit points onto Brep surfaces.

### Method
POST

### Endpoint
/api/curves/projectToBrep/multipleCurvesMultipleBrepsLoose

### Parameters
#### Request Body
- **curves** (IEnumerable<Curve>) - Required - The curves to project.
- **breps** (IEnumerable<Brep>) - Required - The Breps to project onto.
- **direction** (Vector3d) - Required - The direction of projection.
- **tolerance** (Double) - Required - The tolerance to use for projection.
- **loose** (Boolean) - Required - If true, then project curve edit points onto Brep surfaces.

### Request Example
```json
{
  "curves": [{"type": "Curve"}],
  "breps": [{"type": "Brep"}],
  "direction": {"x": 1.0, "y": 0.0, "z": 0.0},
  "tolerance": 0.01,
  "loose": true
}
```

### Response
#### Success Response (200)
- **projectedCurves** (Curve[]) - An array of projected curves.
- **curveIndices** (Int32[]) - Index of which curve in the input list was the source for a curve in the return array.
- **brepIndices** (Int32[]) - Index of which brep was used to generate a curve in the return array.

#### Response Example
```json
{
  "projectedCurves": [
    {"type": "Curve"}
  ],
  "curveIndices": [0],
  "brepIndices": [0]
}
```
```

--------------------------------

### HashTime Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.contenthash/hashtime

Gets the hash time, rounded to seconds. This property is available starting from version 6.0.

```APIDOC
## HashTime Property

### Description
Gets the hash time, rounded to seconds.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.FileIO/ContentHash/HashTime

### Parameters

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **HashTime** (DateTime) - The hash time, rounded to seconds.

#### Response Example
{
  "HashTime": "2023-10-27T10:30:00Z"
}
```

--------------------------------

### FileSkpReadOptions - ToDictionary Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileskpreadoptions/todictionary

Converts the current FileSkpReadOptions settings into an ArchivableDictionary. This dictionary can be used with the RhinoDoc.Import function to apply these options during file import.

```APIDOC
## FileSkpReadOptions.ToDictionary()

### Description
Creates a dictionary of the current import options. This dictionary can be passed to the RhinoDoc.Import function.

### Method
`public ArchivableDictionary ToDictionary()`

### Endpoint
N/A (This is a method within a class)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Return Value)
- **ArchivableDictionary** (Type) - A dictionary containing the import options.

#### Response Example
```json
{
  "option1": "value1",
  "option2": 123
}
```
```

--------------------------------

### WriteRenderSettings Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.binaryarchivewriter/writerendersettings

Writes a RenderSettings value to the archive using the BinaryArchiveWriter.

```APIDOC
## WriteRenderSettings

### Description
Writes a RenderSettings value to the archive.

### Method
Public Void

### Endpoint
Rhino.FileIO.BinaryArchiveWriter.WriteRenderSettings(RenderSettings value)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
* **value** (RenderSettings) - Required - A value to write.

### Request Example
```json
{
  "value": { /* RenderSettings object */ }
}
```

### Response
#### Success Response (200)
Type: Void

#### Response Example
(No response body for Void return type)
```

--------------------------------

### LicenseUtils - Initialize Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.licenseutils/initialize

Initializes the license manager for RhinoCommon. This method is crucial for setting up license validation.

```APIDOC
## Initialize Method

### Description
Initializes the license manager.

### Method
public static Boolean Initialize()

### Endpoint
Rhino.PlugIns.LicenseUtils

### Parameters
None

### Request Example
```json
{
  "example": "No request body needed for this method."
}
```

### Response
#### Success Response (200)
- **Boolean** (Boolean) - Returns true if the license manager was initialized successfully, false otherwise.

#### Response Example
```json
{
  "example": "true"
}
```

### Available since
5.0
```

--------------------------------

### RealtimeDisplayMode.DrawMiddlegroundEventArgs Class Documentation

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.realtimedisplaymode

Detailed documentation for the RealtimeDisplayMode.DrawMiddlegroundEventArgs class.

```APIDOC
## RealtimeDisplayMode.DrawMiddlegroundEventArgs Class

### Description
Represents event arguments for drawing the middle ground in a real-time display mode. This class inherits from EventArgs.

### Namespace
Rhino.Render

### Inheritance
EventArgs -> RealtimeDisplayMode.DrawMiddlegroundEventArgs

### Constructors (1)

#### RealtimeDisplayMode.DrawMiddlegroundEventArgs(DisplayPipeline dp)

* **Description**: Initializes a new instance of the RealtimeDisplayMode.DrawMiddlegroundEventArgs class.
* **Parameters**:
  * **dp** (DisplayPipeline) - Required - The display pipeline.

### Properties (1)

#### Pipeline

* **Description**: Gets the display pipeline associated with the event.
* **Type**: DisplayPipeline
```

--------------------------------

### FileCd Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filecd/filecd

Initializes a new instance of the FileCd class.

```APIDOC
## FileCd Constructor

### Description
Initializes a new instance of the FileCd class.

### Method
Constructor

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "FileCd()"
}
```

### Response
#### Success Response (Instance Creation)
- **FileCd object**: A new instance of the FileCd class.

#### Response Example
```json
{
  "example": "(Instance of FileCd)"
}
```
```

--------------------------------

### Get Current Rhino ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/currentrhinoid

Retrieves the unique identifier (Guid) for the currently running Rhino instance using the RhinoApp.CurrentRhinoId property. This property does not take any parameters and returns a Guid object. Ensure RhinoCommon is referenced in your project.

```csharp
System.Guid rhinoId = Rhino.RhinoApp.CurrentRhinoId;
// The rhinoId variable now holds the current Rhino instance's ID.
```

--------------------------------

### Get Rhino.Geometry.Light by GUID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.lightmanagersupport/lightfromid

Retrieves a Rhino.Geometry.Light object from the Rhino document using its unique identifier (GUID). This method is part of the LightManagerSupport class and returns a boolean indicating success. Available since Rhino version 6.0.

```csharp
public abstract Boolean LightFromId(
  RhinoDoc doc,
  Guid uuid,
  ref Light light
)
```

--------------------------------

### FileX3dvWriteOptions.ToDictionary

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filex3dvwriteoptions/todictionary

Creates a dictionary of export options that can be passed to the RhinoDoc.Export function.

```APIDOC
## FileX3dvWriteOptions.ToDictionary

### Description
Creates a dictionary of these options. This dictionary can be passed to the RhinoDoc.Export function.

### Method
`public ArchivableDictionary ToDictionary()`

### Endpoint
Rhino.FileIO/FileX3dvWriteOptions/ToDictionary

### Parameters
None

### Request Example
```json
{
  "example": "No request body for this method."
}
```

### Response
#### Success Response (200)
- **ArchivableDictionary** - A dictionary containing the export options.

#### Response Example
```json
{
  "example": "ArchivableDictionary object containing export options"
}
```
```

--------------------------------

### Create Basic Render Environment (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderenvironment/newbasicenvironment

Constructs a new RenderEnvironment from a SimulatedEnvironment. This overload requires a RhinoDoc object.

```csharp
public static RenderEnvironment NewBasicEnvironment(
  SimulatedEnvironment environment,
  RhinoDoc doc
)
```

--------------------------------

### Get RhinoEdgeAnalysisModeId (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.visualanalysismode/rhinoedgeanalysismodeid

Retrieves the static Guid identifier for Rhino's built-in edge analysis mode. This mode is used to display Brep and mesh edges in a specified color. The property is read-only and returns a Guid.

```csharp
public static Guid RhinoEdgeAnalysisModeId { get; }
```

--------------------------------

### Get Decal Start Longitude (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.decal/startlongitude

Retrieves the start angle of a decal's arc of longitude. This value is used for spherical mapping and is deprecated in favor of the VertSweep() method. The method returns a double representing the angle.

```csharp
public double StartLongitude {get}

```

--------------------------------

### PlugIn.CreateCommands Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/createcommands

This method is responsible for initializing all commands within a Rhino plug-in. It is called automatically when the plug-in is loaded.

```APIDOC
## PlugIn.CreateCommands Method

### Description
Called right after plug-in is created and is responsible for creating all of the commands in a given plug-in. The base class implementation Constructs an instance of every publicly exported command class in your plug-in's assembly.

### Method
`protected virtual Void CreateCommands()`

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response
Type: Void

#### Response Example
N/A
```

--------------------------------

### UserData Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.custom.userdata/userdata

Initializes a new instance of the UserData class.

```APIDOC
## UserData()

### Description
Initializes a new instance of the UserData class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "UserData()"
}
```

### Response
#### Success Response (200)
- **UserData** (UserData) - An initialized instance of the UserData class.

#### Response Example
```json
{
  "example": "// Example of creating a UserData instance\nvar userData = new Rhino.DocObjects.Custom.UserData();"
}
```
```

--------------------------------

### Accessing ObjectId Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.objectattributes/objectid

Demonstrates how to get and set the ObjectId property for Rhino objects using C#. This property uses a Guid to uniquely identify objects within a Rhino document. If the ObjectId is Guid.Empty when an object is added, a new GUID is generated. Existing GUIDs are preserved during updates like moves.

```csharp
using Rhino.DocObjects;
using Rhino.Geometry;

// ... inside a RhinoCommon command or plugin

// Get the attributes of an object
ObjectAttributes attributes = doc.ObjectAttributes;

// Get the ObjectId
Guid objectId = attributes.ObjectId;

// Check if the ObjectId is empty
if (objectId == Guid.Empty) {
    // A new GUID will be generated when the object is added.
}

// Set a specific ObjectId (use with caution to avoid collisions)
// attributes.ObjectId = new Guid("some-unique-guid-string");

// Update the object with new attributes
// doc.ModifyObjectAttributes(objectId, attributes, false);

```

--------------------------------

### ThumbData Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.controls.thumbnailui.thumbdata/thumbdata

Initializes a new instance of the ThumbData class.

```APIDOC
## ThumbData()

### Description
Initializes a new instance of the ThumbData class.

### Method
GET

### Endpoint
/Rhino.UI.Controls.ThumbnailUI/ThumbData

### Parameters
No parameters are required for this constructor.

### Request Example
```json
{
  "message": "No request body needed for constructor initialization."
}
```

### Response
#### Success Response (200)
- **ThumbData** (object) - An initialized instance of the ThumbData class.

#### Response Example
```json
{
  "example": "ThumbData object initialized successfully"
}
```
```

--------------------------------

### Get Layer Name by GUID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.textfields/layername

Retrieves the name of a layer in Rhino using its unique GUID. This method is part of the Rhino.Runtime.TextFields class and requires the layer's ID as a string input. It returns the layer name as a string.

```csharp
public static String LayerName(
String layerId
)
```

--------------------------------

### CreateBaseballSphere()

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Brep

Creates a Brep representation of a sphere with two trimmed NURBS surfaces.

```APIDOC
## CreateBaseballSphere(Point3d center, Double radius, Double tolerance)

### Description
Creates a brep representation of the sphere with two similar trimmed NURBS surfaces, and no singularities.

### Method
(Implicitly part of a larger object or class)

### Endpoint
N/A

### Parameters
- **center** (Point3d) - The center of the sphere.
- **radius** (Double) - The radius of the sphere.
- **tolerance** (Double) - The geometric tolerance.

### Request Example
None

### Response
- **Brep** - The created sphere Brep.
```

--------------------------------

### CommandAliasList Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.commandaliaslist/commandaliaslist

Initializes a new instance of the CommandAliasList class.

```APIDOC
## CommandAliasList()

### Description
Initializes a new instance of the CommandAliasList class.

### Method
Constructor

### Endpoint
N/A

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{}
```

### Response
#### Success Response (N/A)
This is a constructor, it does not return a response in the traditional sense.

#### Response Example
```json
null
```
```

--------------------------------

### Get WireframeAnnotationsRGBA Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectuuids/wireframeannotationsrgba

Retrieves the static Guid for WireframeAnnotationsRGBA from the PostEffectUuids class. This property is used to identify specific post-effect settings related to wireframe annotations. No specific input parameters are required as it's a static getter.

```csharp
using System;

// Assuming RhinoCommon is referenced
// using Rhino.Render.PostEffects;

public class ExampleUsage {
    public void GetWireframeColor() {
        Guid wireframeColorGuid = Rhino.Render.PostEffects.PostEffectUuids.WireframeAnnotationsRGBA;
        Console.WriteLine($"Wireframe Annotations RGBA Guid: {wireframeColorGuid}");
    }
}
```

--------------------------------

### Access Rhino Lights Panel Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/lightmanager

This code snippet demonstrates how to access the static LightManager property from the Rhino.UI.PanelIds class. This property returns a Guid that identifies the Rhino Lights panel. It is available starting from Rhino version 5.0.

```csharp
public static Guid LightManager {get}
```

--------------------------------

### IHelp.HelpUrl Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.ihelp/helpurl

Provides the URL for help topics within the Rhino interface.

```APIDOC
## Rhino.UI.IHelp.HelpUrl

### Description
This property returns a string representing the URL for help topics, which can be passed to RhinoHelp.Show.

### Method
Get

### Endpoint
N/A (This is a property within a class)

### Parameters
This property does not take any parameters.

### Request Example
N/A (This is a property, not an endpoint)

### Response
#### Success Response
- **string** - The URL for help topics.

#### Response Example
```
"https://example.rhino3d.com/help"
```

### Availability
Available since Rhino version 6.0.
```

--------------------------------

### Rhino.PlugIns.PlugIn.LoadPlugIn(String, out Guid)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/loadplugin

Attempts to load a plug-in from a specified file path. This method also serves as an installation routine as loaded plug-ins are remembered between sessions.

```APIDOC
## Rhino.PlugIns.PlugIn.LoadPlugIn(String, out Guid)

### Description
Attempts to load a plug-in from a specified file path. Loaded plug-ins are remembered by Rhino between sessions, so this function can also be considered a plug-in installation routine.

### Method
`public static LoadPlugInResult LoadPlugIn(String path, out Guid plugInId)`

### Parameters
#### Path Parameters
* None

#### Query Parameters
* None

#### Request Body
* None

### Request Example
```json
{
  "path": "C:\\Path\\To\\MyPlugin.rhp"
}
```

### Response
#### Success Response (200)
* **Type**: LoadPlugInResult - Indicates the result of the plug-in loading attempt.
* **plugInId** (Guid) - If successful (or the plug-in is already loaded), the unique id for the plug-in is returned here. Guid.Empty on failure.

#### Response Example
```json
{
  "result": "Success",
  "plugInId": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

**Available since**: 6.0
```

--------------------------------

### Get and Set AltUnitsDisplay Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.dimension/altunitsdisplay

Demonstrates how to get or set the AltUnitsDisplay property, which controls whether alternate units are displayed in Rhino dimensions. This property returns a boolean value and can be set to true or false. It is available starting from Rhino 6.0.

```csharp
bool display = dimension.AltUnitsDisplay;
// or
dimension.AltUnitsDisplay = true;
```

--------------------------------

### Get or Set Animation Start Day (RhinoCommon API)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.animationproperties/startday

This property retrieves or modifies the starting day for seasonal or one-day sun animations. The value must be an integer between 1 and 31, inclusive. It is available since version 6.11 of the RhinoCommon API.

```csharp
public int StartDay { get; set; }
```

--------------------------------

### BrepVertex Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_BrepVertex

Information about the constructors available for the BrepVertex class.

```APIDOC
## BrepVertex Constructors

### Description
Provides details on how to instantiate a BrepVertex object.

### Constructors

*   **CommonObject()**
    Allows construction from inheriting classes.

*   **CommonObject(SerializationInfo info, StreamingContext context)**
    Protected constructor for internal use.

*   **GeometryBase(SerializationInfo info, StreamingContext context)**
    Protected constructor for internal use.

*   **Point(Point3d location)**
    Initializes a new point instance with a location.

*   **Point(SerializationInfo info, StreamingContext context)**
    Protected constructor for internal use.
```

--------------------------------

### Get UseGroupLayers Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileskpreadoptions/usegrouplayers

This C# code snippet demonstrates how to get the value of the UseGroupLayers property from a FileSkpReadOptions object. This boolean property indicates whether group layers are being used when reading SKP files. It is available starting from Rhino 8.0.

```csharp
Rhino.FileIO.FileSkpReadOptions options = new Rhino.FileIO.FileSkpReadOptions();
bool useGroups = options.UseGroupLayers;
```

--------------------------------

### ZooClientParameters.LicenseGuid

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.zooclientparameters/licenseguid

Gets the Guid used by ZooClient to identify the license saved by ZooClient. This differs from ProductGuid because different versions of a plug-in with the same Plug-in ID may need different licenses.

```APIDOC
## LicenseGuid Property

### Description
Guid used by ZooClient to identify the license saved by ZooClient. This differs from ProductGuid because different versions of a plug-in with the same Plug-in ID may need different licenses.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Runtime/ZooClientParameters/LicenseGuid

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **LicenseGuid** (Guid) - The unique identifier for the license.

#### Response Example
```json
{
  "LicenseGuid": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```
```

--------------------------------

### Load Plug-in from Path

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/loadplugin

Attempts to load a plug-in from a specified file path. This method also functions as a plug-in installation routine, as loaded plug-ins are remembered between Rhino sessions. It returns a LoadPlugInResult and the plug-in's Guid if successful.

```csharp
public static LoadPlugInResult LoadPlugIn(
  String path,
  out Guid plugInId
)
```

--------------------------------

### Initialize FileSkp Class Instance

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileskp/fileskp

Initializes a new instance of the FileSkp class. This constructor does not require any parameters.

```csharp
FileSkp() {
  // Initializes a new instance of the FileSkp class
}
```

--------------------------------

### Get or Set CreateBackupFiles Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.filesettingsstate/createbackupfiles

This C# code demonstrates how to get or set the CreateBackupFiles property. This property controls whether backup files are generated when saving in Rhino. It is available starting from version 5.0 of the RhinoCommon API.

```csharp
using Rhino.ApplicationSettings;

// Get the current value
bool backupEnabled = FileSettingsState.CreateBackupFiles;

// Set a new value
FileSettingsState.CreateBackupFiles = true;
FileSettingsState.CreateBackupFiles = false;
```

--------------------------------

### Rhino.Geometry.Dimension.DetailMeasured Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.dimension/detailmeasured

Details about the DetailMeasured property, which is part of the Dimension class within the Rhino.Geometry namespace. This property is used to get or set a Guid value.

```APIDOC
## Rhino.Geometry.Dimension.DetailMeasured Property

### Description
Represents the measured detail of a dimension. This property allows you to get or set the Guid associated with the measured detail.

### Method
Read/Write

### Endpoint
N/A (This is a property within a class)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// To get the DetailMeasured property:
Guid measuredDetailId = dimension.DetailMeasured;

// To set the DetailMeasured property:
dimension.DetailMeasured = new Guid("some-guid-value");
```

### Response
#### Success Response (200)
N/A (This is a property, not an endpoint)

#### Response Example
```json
{
  "returnValue": "Guid"
}
```

### Remarks
Type: Guid
Available since: 6.0
```

--------------------------------

### CreatePlanarUnion (Two Breps)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createplanarunion

Creates a planar union of two Breps lying on a specified plane with a given tolerance.

```APIDOC
## POST /api/brep/createPlanarUnion/two

### Description
Creates a planar union of two Breps that lie on a specified plane, using a given tolerance for the operation.

### Method
POST

### Endpoint
/api/brep/createPlanarUnion/two

### Parameters
#### Request Body
- **b0** (Brep) - Required - The first Brep to union.
- **b1** (Brep) - Required - The second Brep to union.
- **plane** (Plane) - Required - The plane in which all input Breps lie.
- **tolerance** (System.Double) - Required - Tolerance to use for the union operation.

### Request Example
```json
{
  "b0": { /* Brep object */ },
  "b1": { /* Brep object */ },
  "plane": { /* Plane object */ },
  "tolerance": 0.01
}
```

### Response
#### Success Response (200)
- **Brep[]** - An array of Brep results or null on failure.

#### Response Example
```json
[
  { /* Brep object 1 */ },
  { /* Brep object 2 */ }
]
```
```

--------------------------------

### CreateFromCone

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Mesh

Constructs a mesh cone with various options for segmentation, caps, and solidity.

```APIDOC
## POST /api/meshes/from_cone

### Description
Constructs a mesh cone.

### Method
POST

### Endpoint
/api/meshes/from_cone

### Parameters
#### Request Body
- **cone** (Cone) - Required - The cone definition.
- **vertical** (Int32) - Optional - Number of divisions along the height.
- **around** (Int32) - Optional - Number of divisions around the circumference.
- **solid** (Boolean) - Optional - Whether to create a solid cone.
- **quadCaps** (Boolean) - Optional - Whether to use quad caps.

### Request Example
```json
{
  "cone": {
    "basePoint": [0,0,0],
    "height": 1.0,
    "radius": 0.5
  },
  "vertical": 10,
  "around": 32,
  "solid": true,
  "quadCaps": false
}
```

### Response
#### Success Response (200)
- **mesh** (Mesh) - The resulting mesh cone.

#### Response Example
```json
{
  "mesh": {
    // ... mesh data ...
  }
}
```
```

--------------------------------

### File3dmPlugInData.PlugInId Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmplugindata/pluginid

Gets the unique identifier (Guid) of the plug-in that is associated with this custom data within a File3dm object.

```APIDOC
## File3dmPlugInData.PlugInId Property

### Description
Gets the id of the plug-in that is associated with this custom data.

### Method
Get

### Endpoint
N/A (Property within a class)

### Parameters
None

### Request Example
N/A (Property access)

### Response
#### Success Response (200)
- **PlugInId** (Guid) - The unique identifier of the associated plug-in.

#### Response Example
```json
{
  "PlugInId": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

### Remarks
Available since RhinoCommon version 5.0.
```

--------------------------------

### Rhino.PlugIns.PlugIn.LoadPlugIn(Guid, Boolean, Boolean)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/loadplugin

Loads an installed plug-in with options for quiet loading and forcing the load even if previous attempts failed.

```APIDOC
## Rhino.PlugIns.PlugIn.LoadPlugIn(Guid, Boolean, Boolean)

### Description
Loads an installed plug-in. Allows for quiet loading and forcing the load.

### Method
`public static Boolean LoadPlugIn(Guid pluginId, Boolean loadQuietly, Boolean forceLoad)`

### Parameters
#### Path Parameters
* None

#### Query Parameters
* None

#### Request Body
* None

### Request Example
```json
{
  "pluginId": "a1b2c3d4-e5f6-7890-1234-567890abcdef",
  "loadQuietly": true,
  "forceLoad": false
}
```

### Response
#### Success Response (200)
* **Type**: Boolean - True if successful, False otherwise.

#### Response Example
```json
{
  "success": true
}
```

**Available since**: 6.0
```

--------------------------------

### DisplayHelp Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/displayhelp

Called by Rhino if AddToHelpMenu is True and the menu item associated with this plug-in is selected.

```APIDOC
## DisplayHelp Method

### Description
Called by Rhino if AddToHelpMenu is True and the menu item associated with this plug-in is selected.

### Method
public virtual Boolean DisplayHelp(IntPtr windowHandle)

### Endpoint
Not applicable (this is a method within the RhinoCommon API).

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// Example of calling the DisplayHelp method (syntax may vary based on context)
bool helpDisplayed = pluginInstance.DisplayHelp(rhinoWindowHandle);
```

### Response
#### Success Response (Boolean)
- **True**: Help displayed successfully.
- **False**: Error displaying help.

#### Response Example
```json
{
  "result": true 
}
```

**Available since:** 8.7
```

--------------------------------

### BackgroundProjection Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.simulatedenvironment/backgroundprojection

This property allows you to get or set the background projection type for a simulated environment. It is available starting from version 5.1 of the RhinoCommon API.

```APIDOC
## BackgroundProjection Property

### Description
Gets or sets the background projection type for a simulated environment.

### Method
Public Property

### Endpoint
Rhino.Render.SimulatedEnvironment.BackgroundProjection

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// To get the current background projection
BackgroundProjections currentProjection = simulatedEnvironment.BackgroundProjection;

// To set a new background projection
simulatedEnvironment.BackgroundProjection = BackgroundProjections.Screen;
```

### Response
#### Success Response (200)
- **Type** (BackgroundProjections) - The current background projection setting.

#### Response Example
```json
{
  "Type": "Screen"
}
```

**Available since:** 5.1
```

--------------------------------

### Initialize DisplayBitmap from Path or Bitmap (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaybitmap/displaybitmap

Creates a DisplayBitmap from either a file path or a System.Drawing.Bitmap object. If a path is provided, the bitmap is loaded from that path and cached. If a Bitmap object is provided, it's used directly and cached with the given path. If both are null, the object is invalid. This constructor does not support URLs for paths. Available since RhinoCommon 7.16.

```csharp
public DisplayBitmap(string path, Bitmap bitmap)
```

--------------------------------

### Rhino.Geometry.RevSurface.Angle Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.revsurface/angle

Gets the start and end angles of revolution in radians. The interval angle must be increasing and satisfy RhinoMath.ZeroTolerance < Angle.Length <= 2.0 * System.Math.PI.

```APIDOC
## Rhino.Geometry.RevSurface.Angle Property

### Description
Gets the start and end angles of revolution in radians. The interval angle must be increasing and satisfy RhinoMath.ZeroTolerance < Angle.Length <= 2.0 * System.Math.PI.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Geometry/RevSurface/Angle

### Parameters

### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Angle** (Interval) - The start and end angles of revolution in radians.

#### Response Example
```json
{
  "Angle": {
    "Start": 0.0,
    "End": 3.141592653589793
  }
}
```
```

--------------------------------

### GetEnglishCommandNames Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getenglishcommandnames

Gets the names of all 'non-test' commands for a given plug-in.

```APIDOC
## Rhino.PlugIns.PlugIn - GetEnglishCommandNames

### Description
Gets names of all "non-test" commands for a given plug-in.

### Method
`public static String[] GetEnglishCommandNames(Guid pluginId)`

### Endpoint
N/A (This is a static method within the RhinoCommon library, not a REST API endpoint.)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// Example usage within a C# environment:
System.Guid myPluginId = new System.Guid("YOUR_PLUGIN_ID_HERE"); 
string[] commandNames = Rhino.PlugIns.PlugIn.GetEnglishCommandNames(myPluginId);
```

### Response
#### Success Response
- **Type**: `String[]`
- **Description**: An array with all plug-in command names. This can be empty, but not null.

#### Response Example
```json
[
  "CommandName1",
  "CommandName2",
  "AnotherCommand"
]
```

### Availability
Available since version 5.0.
```

--------------------------------

### ProjectToBrep (Curve, IEnumerable<Brep>, Vector3d, Double, out Int32[])

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.curve/projecttobrep

Projects a single Curve onto a collection of Breps along a given direction, returning the projected curves and indices of the Breps they were projected onto.

```APIDOC
## POST /api/curves/projectToBrep/multipleBreps

### Description
Projects a Curve onto a collection of Breps along a given direction.

### Method
POST

### Endpoint
/api/curves/projectToBrep/multipleBreps

### Parameters
#### Request Body
- **curve** (Curve) - Required - The curve to project.
- **breps** (IEnumerable<Brep>) - Required - The collection of Breps to project onto.
- **direction** (Vector3d) - Required - The direction of projection.
- **tolerance** (Double) - Required - The tolerance to use for projection.

### Request Example
```json
{
  "curve": {"type": "Curve"},
  "breps": [{"type": "Brep"}],
  "direction": {"x": 1.0, "y": 0.0, "z": 0.0},
  "tolerance": 0.01
}
```

### Response
#### Success Response (200)
- **projectedCurves** (Curve[]) - An array of projected curves or an empty array if the projection set is empty.
- **brepIndices** (Int32[]) - Integers that identify for each resulting curve which Brep it was projected onto.

#### Response Example
```json
{
  "projectedCurves": [
    {"type": "Curve"}
  ],
  "brepIndices": [0]
}
```
```

--------------------------------

### Get Cylinder Height1 (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.cylinder/height1

Retrieves the start height of a cylinder using the Height1 property. This value is a double representing the height.

```csharp
double height = cylinder.Height1;
```

--------------------------------

### Get Rhino 3 ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/rhino3id

This C# code snippet demonstrates how to access the static Rhino3Id property from the Rhino.RhinoApp class to retrieve the Guid identifier for Rhino 3. No input parameters are required. The output is a Guid object.

```csharp
using System;

public class RhinoAppExample {
    public static void Main() {
        Guid rhino3Id = Rhino.RhinoApp.Rhino3Id;
        Console.WriteLine("Rhino 3 ID: " + rhino3Id);
    }
}
```

--------------------------------

### HudStartTime Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.realtimedisplaymode/hudstarttime

Retrieves the start time of the HUD (Heads-Up Display) in the RealtimeDisplayMode.

```APIDOC
## HudStartTime Method

### Description
Retrieves the start time of the HUD (Heads-Up Display) in the RealtimeDisplayMode.

### Method
`public virtual DateTime HudStartTime()`

### Endpoint
N/A (This is a method within the RhinoCommon library, not a REST endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response
- **DateTime** (DateTime) - The start time of the HUD.

#### Response Example
```json
{
  "startTime": "2023-10-27T10:30:00Z"
}
```

### Available since
6.0
```

--------------------------------

### Initialize RhinoApp Instance

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/rhinoapp

This code snippet demonstrates how to initialize a new instance of the RhinoApp class. This is a core step for interacting with the Rhino application environment through the RhinoCommon API.

```csharp
RhinoApp(){
  // Constructor implementation
}
```

--------------------------------

### Get Parent Object Guid (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.changequeue.mesh/id

The Id() method returns the Guid of the parent object to which this mesh belongs. This is useful for referencing or manipulating the parent object within the Rhino scene. No specific dependencies are required beyond the RhinoCommon library.

```csharp
public Guid Id()
{
  // Implementation returns the Guid of the parent object
}
```

--------------------------------

### GetActivePlugInVersionFolders (No Parameters)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/getactivepluginversionfolders

Recurses through the auto install plug-in folders and returns the directories containing 'active' versions of plug-ins. If the same package is installed in both the user and machine locations, the newest directory wins.

```APIDOC
## GetActivePlugInVersionFolders

### Description
Recurses through the auto install plug-in folders and returns the directories containing "active" versions of plug-ins. If the same package is installed in both the user and machine locations, the newest directory wins.

### Method
GET

### Endpoint
/Rhino.Runtime/HostUtils/GetActivePlugInVersionFolders

### Parameters
#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{}
```

### Response
#### Success Response (200)
- **directories** (DirectoryInfo[]>)
  - A list of directory information for active plug-in versions.

#### Response Example
```json
{
  "directories": [
    {
      "fullName": "C:\\Program Files\\Rhino 7\\Plug-ins\\MyPlugin",
      "name": "MyPlugin",
      "exists": true
    }
  ]
}
```
```

--------------------------------

### SimpleArrayGuid Class

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_InteropWrappers_SimpleArrayGuid

Documentation for the SimpleArrayGuid class, including its constructors, properties, and methods.

```APIDOC
## SimpleArrayGuid Class

Wrapper for ON_SimpleArray. If you are not writing C++ code then this class is not for you.

### Namespace
Rhino.Runtime.InteropWrappers

### Constructors

#### SimpleArrayGuid()
Initializes a new `SimpleArrayGuid` class.

#### SimpleArrayGuid(IEnumerable<Guid> values)
Initializes a new `SimpleArrayGuid` class with the provided values.

### Properties

#### Capacity
Gets or sets the capacity for the array.

#### Count
Gets the amount of elements in this array.

#### Item
Gets the `Guid` at the specified index.

### Methods

#### Append(Guid uuid)
Appends a new `Guid` at the end of this array.

#### ConstPointer()
Gets the constant (immutable) pointer of this array.

#### Dispose()
Actively reclaims unmanaged resources that this instance uses.

#### NonConstPointer()
Gets the non-constant pointer (for modification) of this array.

#### ToArray()
Returns the managed counterpart of the unmanaged array.
```

--------------------------------

### Get Guid with Legacy Keys (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.persistentsettings/getguid

Retrieves a Guid value from persistent settings using a primary key, a default value if the key is not found, and an optional list of legacy keys to check. Available since Rhino 6.0.

```csharp
public Guid GetGuid(
  String key,
  Guid defaultValue,
  IEnumerable<string> legacyKeyList
)
```

--------------------------------

### RhinoCore Constructors

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.inprocess

Initializes a new instance of the RhinoCore class with various optional parameters.

```APIDOC
## RhinoCore Constructors

### Description
Initializes a new instance of the <b>RhinoCore</b> class.

### Method
CONSTRUCTOR

### Endpoint
N/A (Class Constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
None

#### Response Example
None
```

--------------------------------

### Get Plane from Line (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.line/trygetplane

Attempts to get a plane containing the line. The origin of the plane is set to the start of the line. If possible, it prioritizes returning a plane parallel to the world XY, YZ, or ZX planes. This method is part of the Rhino.Geometry.Line class.

```csharp
public Boolean TryGetPlane(  
out Plane plane  
)
```

--------------------------------

### FileGHS Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileghs/fileghs

Initializes a new instance of the FileGHS class. This constructor is part of the Rhino.FileIO namespace.

```APIDOC
## FileGHS Constructor

### Description
Initializes a new instance of the FileGHS class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
This constructor does not take any parameters.

### Request Example
```csharp
// Example of how to use the constructor in C#
Rhino.FileIO.FileGHS myFileGHS = new Rhino.FileIO.FileGHS();
```

### Response
#### Success Response
Creates a new FileGHS object.

#### Response Example
```json
// No direct JSON response for a constructor
// The result is an object instance in memory.
```
```

--------------------------------

### SetFirstPoint Method Example (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getpolyline/setfirstpoint

This C# code snippet demonstrates how to use the SetFirstPoint method to define the starting point of a polyline in RhinoCommon. It requires the RhinoCommon library and takes a Point3d object as input.

```csharp
using Rhino.Input.Custom;
using Rhino.Geometry;

// ... inside a Rhino command or other context
GetPolyline getPolyline = new GetPolyline();
Point3d startPoint = new Point3d(10, 20, 0);
getPolyline.SetFirstPoint(startPoint);
// Now proceed with getting the rest of the polyline points
getPolyline.Get();

```

--------------------------------

### Get Viewport Tabs Visibility at Start (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.appearancesettings/viewporttabsvisibleatstart

This C# code snippet shows how to retrieve the current value of the ViewportTabsVisibleAtStart property. This allows you to check whether viewport tabs are configured to be visible when Rhino starts. The function returns a boolean value indicating the current setting.

```csharp
using Rhino.ApplicationSettings;

bool tabsVisible = AppearanceSettings.ViewportTabsVisibleAtStart;

if (tabsVisible)
{
    Rhino.RhinoApp.WriteLine("Viewport tabs are set to be visible at start.");
}
else
{
    Rhino.RhinoApp.WriteLine("Viewport tabs are set to be hidden at start.");
}
```

--------------------------------

### RhinoHelp Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.rhinohelp/rhinohelp

Initializes a new instance of the RhinoHelp class.

```APIDOC
## RhinoHelp constructor

### Description
Initializes a new instance of the RhinoHelp class.

### Method
RhinoHelp()

### Endpoint
N/A

### Parameters
None

### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
Initializes a RhinoHelp object.

#### Response Example
None
```

--------------------------------

### Get and Set Light Specular Color (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.light/specular

This C# code demonstrates how to get and set the specular color of a light object using the RhinoCommon API. The Specular property returns or accepts a System.Drawing.Color object. Availability starts from Rhino 5.0.

```csharp
using Rhino.Geometry;
using System.Drawing;

// Assuming 'myLight' is an existing Light object

// Get the specular color
Color specularColor = myLight.Specular;

// Set a new specular color (e.g., red)
myLight.Specular = Color.Red;

```

--------------------------------

### Get or Set Clipping Plane Solid Color (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaypipelineattributes/clippingshadecolor

The ClippingShadeColor property in Rhino.Display.DisplayPipelineAttributes allows you to get or set the solid color used for clipping plane shades. This feature is available starting from version 8.11. It returns a Color object.

```csharp
public Color ClippingShadeColor {get|set}
```

--------------------------------

### SerializationOptions Class Documentation

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio

Documentation for the SerializationOptions class, including its constructor and properties.

```APIDOC
## SerializationOptions Class

### Description
Contains options for serializing -or storing- data, such as Rhino version, user data, and meshes.

### Namespace
Rhino.FileIO

### Constructors
#### SerializationOptions()
Initializes a new instance of the `SerializationOptions` class.

### Properties
#### MaxRhinoVersion
Gets the most recent serialization version available.

#### MinRhinoVersion
Gets the earliest serialization version available.

#### RhinoVersion
Gets or sets a value indicating the Rhino version.

#### WriteAnalysisMeshes
Gets or sets a value indicating whether to write analysis meshes.

#### WriteRenderMeshes
Gets or sets a value indicating whether to write render meshes.

#### WriteUserData
Gets or sets a value indicating whether to write user data.

```

--------------------------------

### StringParser Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.stringparser/stringparser

Initializes a new instance of the StringParser class.

```APIDOC
## StringParser()

### Description
Initializes a new instance of the StringParser class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Body
None

### Request Example
None

### Response
#### Success Response (N/A)
This is a constructor, no direct response.

#### Response Example
None
```

--------------------------------

### Get Installed Rhino Plug-in Count (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/installedplugincount

This C# code snippet retrieves the number of installed Rhino plug-ins using the InstalledPlugInCount property. This property is part of the Rhino.PlugIns.PlugIn class and requires no input parameters. It returns an integer value.

```csharp
int count = Rhino.PlugIns.PlugIn.InstalledPlugInCount;
System.Console.WriteLine($"Number of installed plug-ins: {count}");
```

--------------------------------

### RhinoApp.Rhino3Id

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/rhino3id

Gets the ID of Rhino 3. This property returns a Guid representing the unique identifier for Rhino 3.

```APIDOC
## RhinoApp.Rhino3Id

### Description
Gets the ID of Rhino 3.

### Method
GET

### Endpoint
/Rhino/RhinoApp/Rhino3Id

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **Rhino3Id** (Guid) - The unique identifier for Rhino 3.

#### Response Example
{
  "Rhino3Id": "<guid-value>"
}
```

--------------------------------

### InitializeRhinoCommon_RDK Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/initializerhinocommon_rdk

Ensures all static RhinoCommon RDK components are set up correctly. This usually happens automatically when the RDK is loaded.

```APIDOC
## InitializeRhinoCommon_RDK()

### Description
Makes sure all static RhinoCommon RDK components are set up correctly. This happens automatically when the RDK is loaded, so you probably won't have to call this method.

### Method
`public static Void InitializeRhinoCommon_RDK()`

### Endpoint
N/A (Static method)

### Parameters
None

### Request Body
None

### Response
#### Success Response (Void)
Returns `Void`. Subsequent calls to this method will be ignored.

### Remarks
Available since RhinoCommon version 6.0.
```

--------------------------------

### TextLog() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.textlog/textlog

Creates a text log that stores all text in memory. Use ToString on this version of the TextLog to get the text that was written.

```APIDOC
## TextLog()

### Description
Creates a text log that stores all text in memory. Use ToString on this version of the TextLog to get the text that was written.

### Method
GET

### Endpoint
/Rhino.FileIO/TextLog/TextLog()

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
- **TextLog** (object) - An instance of the TextLog class.

#### Response Example
None
```

--------------------------------

### Create Brep from Curves (Loft) (RhinoCommon C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfromloft

Constructs one or more Breps by lofting through a set of curves. Curves must be pre-sorted and their directions/seams adjusted if necessary. Supports optional start and end points.

```csharp
public static Brep[] CreateFromLoft(
  IEnumerable<Curve> curves,
  Point3d start,
  Point3d end,
  LoftType loftType,
  Boolean closed
)
```

--------------------------------

### Rhino.DocObjects.Layer.PerViewportPlotColor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.layer/perviewportplotcolor

Gets the plot color for a specific layer in a given viewport. If an empty Guid is provided, it retrieves the default plot color for the layer.

```APIDOC
## PerViewportPlotColor method

### Description
Gets the plot color for this layer.

### Method
`public Color PerViewportPlotColor(Guid viewportId)`

### Endpoint
Not applicable for this SDK method.

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "viewportId": "00000000-0000-0000-0000-000000000000"
}
```

### Response
#### Success Response (200)
- **Color** (Color) - The plot color.

#### Response Example
```json
{
  "color": "System.Drawing.Color [A=255, R=0, G=0, B=0]"
}
```

### Remarks
- Available since Rhino version 6.0.
- If `viewportId` is `Guid.Empty`, the setting applies to all viewports.
- Otherwise, the setting applies only to the viewport with the specified `viewportId`.
```

--------------------------------

### Initialize RhinoCore with Arguments and Window Style (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.inprocess.rhinocore/rhinocore

Initializes a new instance of the RhinoCore class with specified command-line arguments and window style. This overload allows for custom startup configurations. For command-line argument details, refer to the C++ guide. Available since Rhino 7.0.

```csharp
public RhinoCore(
  string[] args,
  WindowStyle windowStyle
)

```

--------------------------------

### Triangle3d.MedianA Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.triangle3d/mediana

Gets the median line of a Triangle3d starting at corner A. This property is available since RhinoCommon version 7.1.

```APIDOC
## Triangle3d.MedianA Property

### Description
Gets the median line starting at corner A.

### Method
GET

### Endpoint
/Triangle3d/MedianA

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{}
```

### Response
#### Success Response (200)
- **MedianA** (Line) - The median line starting at corner A.

#### Response Example
```json
{
  "MedianA": {
    "PointA": [0.0, 0.0, 0.0],
    "PointB": [1.0, 0.0, 0.0],
    "Direction": [0.0, 1.0, 0.0]
  }
}
```
```

--------------------------------

### Rhino.FileIO.FileVdaWriteOptions.ObjectCode

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filevdawriteoptions/objectcode

The ObjectCode property in the FileVdaWriteOptions class allows you to get or set a string value representing the object code. This property is available starting from version 8.0.

```APIDOC
## Rhino.FileIO.FileVdaWriteOptions.ObjectCode

### Description
Gets or sets the object code.

### Method
public string ObjectCode {get|set}

### Endpoint
N/A (Class Property)

### Parameters
#### Path Parameters
N/A

#### Query Parameters
N/A

#### Request Body
N/A

### Request Example
N/A

### Response
#### Success Response (200)
Type: string
Description: The object code associated with the file VDA write options.

#### Response Example
```json
{
  "ObjectCode": "example_code"
}
```

### Remarks
Available since: 8.0
```

--------------------------------

### SetLayout Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.viewcapturesettings/setlayout

Configures the layout settings for view capture, including media size and cropping.

```APIDOC
## SetLayout Method

### Description
Configures the layout settings for view capture, specifying the media size and a cropping rectangle.

### Method
`public Void SetLayout(Size mediaSize, Rectangle cropRectangle)`

### Endpoint
Rhino.Display.ViewCaptureSettings

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **mediaSize** (Size) - Required - The desired media size for the capture.
- **cropRectangle** (Rectangle) - Required - The rectangle defining the area to crop within the view.

### Request Example
```json
{
  "mediaSize": {
    "Width": 1920,
    "Height": 1080
  },
  "cropRectangle": {
    "X": 100,
    "Y": 100,
    "Width": 1720,
    "Height": 880
  }
}
```

### Response
#### Success Response (200)
- **Void** - This method does not return a value.

#### Response Example
None (void method)

### Available Since
6.0
```

--------------------------------

### Point and Size Settings API

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_PersistentSettings

Methods for getting and setting Point, Point3d, and Size values.

```APIDOC
## GET /api/settings/point

### Description
Retrieves a Point value associated with a given key.

### Method
GET

### Endpoint
/api/settings/point

### Parameters
#### Query Parameters
- **key** (string) - Required - The key for the Point value.

### Response
#### Success Response (200)
- **value** (object) - The retrieved Point value with X and Y coordinates.

#### Response Example
```json
{
  "value": {"X": 10, "Y": 20}
}
```

## SET /api/settings/point

### Description
Sets a Point value associated with a given key.

### Method
POST

### Endpoint
/api/settings/point

### Parameters
#### Request Body
- **key** (string) - Required - The key for the Point value.
- **value** (object) - Required - The Point value to set (e.g., `{"X": 10, "Y": 20}`).

### Request Example
```json
{
  "key": "startPoint",
  "value": {"X": 5, "Y": 15}
}
```

### Response
#### Success Response (200)
- **message** (string) - Confirmation message.

#### Response Example
```json
{
  "message": "Point value set successfully."
}
```

## GET /api/settings/point3d

### Description
Retrieves a Point3d value associated with a given key.

### Method
GET

### Endpoint
/api/settings/point3d

### Parameters
#### Query Parameters
- **key** (string) - Required - The key for the Point3d value.

### Response
#### Success Response (200)
- **value** (object) - The retrieved Point3d value with X, Y, and Z coordinates.

#### Response Example
```json
{
  "value": {"X": 10, "Y": 20, "Z": 30}
}
```

## SET /api/settings/point3d

### Description
Sets a Point3d value associated with a given key.

### Method
POST

### Endpoint
/api/settings/point3d

### Parameters
#### Request Body
- **key** (string) - Required - The key for the Point3d value.
- **value** (object) - Required - The Point3d value to set (e.g., `{"X": 10, "Y": 20, "Z": 30}`).

### Request Example
```json
{
  "key": "centerPoint",
  "value": {"X": 1, "Y": 2, "Z": 3}
}
```

### Response
#### Success Response (200)
- **message** (string) - Confirmation message.

#### Response Example
```json
{
  "message": "Point3d value set successfully."
}
```

## GET /api/settings/size

### Description
Retrieves a Size value associated with a given key.

### Method
GET

### Endpoint
/api/settings/size

### Parameters
#### Query Parameters
- **key** (string) - Required - The key for the Size value.

### Response
#### Success Response (200)
- **value** (object) - The retrieved Size value with Width and Height.

#### Response Example
```json
{
  "value": {"Width": 100, "Height": 50}
}
```

## SET /api/settings/size

### Description
Sets a Size value associated with a given key.

### Method
POST

### Endpoint
/api/settings/size

### Parameters
#### Request Body
- **key** (string) - Required - The key for the Size value.
- **value** (object) - Required - The Size value to set (e.g., `{"Width": 100, "Height": 50}`).

### Request Example
```json
{
  "key": "windowSize",
  "value": {"Width": 800, "Height": 600}
}
```

### Response
#### Success Response (200)
- **message** (string) - Confirmation message.

#### Response Example
```json
{
  "message": "Size value set successfully."
}
```
```

--------------------------------

### RhinoObject.FromRuntimeSerialNumber

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.rhinoobject/fromruntimeserialnumber

Gets a Rhino object for a unique runtime serial number. This method is available starting from version 6.0 of the RhinoCommon API.

```APIDOC
## RhinoObject.FromRuntimeSerialNumber

### Description
Gets a Rhino object for a unique runtime serial number.

### Method
`static RhinoObject`

### Endpoint
`Rhino.DocObjects.RhinoObject.FromRuntimeSerialNumber(UInt32 serialNumber)`

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// Assuming 'rhinoObject' is a valid RhinoObject instance
UInt32 serialNumber = rhinoObject.RuntimeSerialNumber;
RhinoObject retrievedObject = Rhino.DocObjects.RhinoObject.FromRuntimeSerialNumber(serialNumber);
```

### Response
#### Success Response (200)
- **RhinoObject** (RhinoObject) - The Rhino object corresponding to the provided serial number. Available since: 6.0

#### Response Example
```json
{
  "runtimeSerialNumber": 12345,
  "name": "MyObject",
  "geometry": { ... } // Represents the geometry of the object
}
```
```

--------------------------------

### File3dmRenderEnvironments Constructor (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmrenderenvironments/file3dmrenderenvironments

Initializes a new instance of the File3dmRenderEnvironments class. This constructor takes a File3dm object as input, which represents the Rhino file to which the render environments will be associated. No specific output or return value is mentioned, implying it sets up the internal state of the object.

```csharp
public File3dmRenderEnvironments(File3dm f)
```

--------------------------------

### FileVrml() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filevrml/filevrml

This section details the constructor for the FileVrml class, used for initializing a new FileVrml object.

```APIDOC
## FileVrml()

### Description
Initializes a new instance of the FileVrml class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "FileVrml newFileVrml = new FileVrml();"
}
```

### Response
#### Success Response (Instance Creation)
- **FileVrml** (Object) - An initialized instance of the FileVrml class.

#### Response Example
```json
{
  "example": "// Instance created successfully"
}
```
```

--------------------------------

### PhysicallyBasedMaterial.SubsurfaceScatteringColor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.physicallybasedmaterial/subsurfacescatteringcolor

The SubsurfaceScatteringColor property within the Rhino.DocObjects.PhysicallyBasedMaterial class allows you to get or set the subsurface scattering color of the material. This property is available starting from version 7.0.

```APIDOC
## PhysicallyBasedMaterial.SubsurfaceScatteringColor Property

### Description
Gets or sets the subsurface scattering color of the material.

### Method
`get | set`

### Endpoint
`Rhino.DocObjects.PhysicallyBasedMaterial.SubsurfaceScatteringColor`

### Parameters
This property does not take any parameters.

### Request Example
```json
{
  "example": "// To get the color:"
}
```
```json
{
  "example": "// To set the color:"
}
```

### Response
#### Success Response (200)
- **Color4f** - The subsurface scattering color.

#### Response Example
```json
{
  "example": "// Example of getting the color:"
}
```
```json
{
  "example": "// Example of setting the color:"
}
```

### Available since
7.0
```

--------------------------------

### HairDensity Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.curvaturegraphsettingsstate/hairdensity

Gets or sets the hair density. This property is of type integer and was made available starting from version 8.0.

```APIDOC
## HairDensity Property

### Description
Gets or sets the hair density.

### Method
GET / SET

### Endpoint
Rhino.ApplicationSettings/CurvatureGraphSettingsState/HairDensity

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "HairDensity": 100
}
```

### Response
#### Success Response (200)
- **HairDensity** (int) - The current hair density value.

#### Response Example
```json
{
  "HairDensity": 100
}
```
```

--------------------------------

### CreatePreviewBitmap

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_DocObjects_InstanceDefinition

Creates a preview bitmap of the instance definition.

```APIDOC
## POST /websites/developer_rhino3d_api/create_preview_bitmap

### Description
Creates a preview bitmap of the instance definition.

### Method
POST

### Endpoint
/websites/developer_rhino3d_api/create_preview_bitmap

### Parameters
- **definedViewportProjection** (DefinedViewportProjection) - The viewport projection to use.
- **displayMode** (DisplayMode) - The display mode for the bitmap.
- **bitmapSize** (Size) - The desired size of the bitmap.
- **applyDpiScaling** (Boolean) - Whether to apply DPI scaling.
- **guid** (Guid) - Optional GUID of the definition object.

### Request Body
```json
{
  "definedViewportProjection": {
    "projectionType": "Perspective",
    "cameraLocation": [0,0,0],
    "cameraDirection": [0,0,1]
  },
  "displayMode": {
    "name": "Shaded"
  },
  "bitmapSize": {
    "width": 200,
    "height": 150
  },
  "applyDpiScaling": true
}
```

### Response
#### Success Response (200)
- **bitmapData** (string) - Base64 encoded string of the preview bitmap image.

#### Response Example
```json
{
  "bitmapData": "/9j/4AAQSkZJRgABAQEAYABgAAD//gAEGB///wAA..."
}
```
```

--------------------------------

### RealtimeDisplayMode.StartRenderer

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.realtimedisplaymode/startrenderer

Overrides to start your render engine. Note that before using the RenderWindow you must call SetSize to properly initialize the underlying DIB.

```APIDOC
## RealtimeDisplayMode.StartRenderer

### Description
Overrides to start your render engine. Note that before using the RenderWindow you must call SetSize to properly initialize the underlying DIB.

### Method
public abstract Boolean StartRenderer(
Int32 w,
Int32 h,
RhinoDoc doc,
ViewInfo view,
ViewportInfo viewportInfo,
Boolean forCapture,
RenderWindow renderWindow
)

### Parameters
#### Path Parameters
* None

#### Query Parameters
* None

#### Request Body
* **w** (System.Int32) - Required - Width of resolution
* **h** (System.Int32) - Required - Height of resolution
* **doc** (RhinoDoc) - Required - Rhino document
* **view** (ViewInfo) - Required - active view
* **viewportInfo** (ViewportInfo) - Required - active viewport info
* **forCapture** (System.Boolean) - Required - True if renderer is started for capture purposes (ViewCaptureTo*), False for regular interactive rendering
* **renderWindow** (RenderWindow) - Required - RenderWindow to hold render results in.

### Request Example
```json
{
  "w": 1920,
  "h": 1080,
  "doc": "<RhinoDoc object>",
  "view": "<ViewInfo object>",
  "viewportInfo": "<ViewportInfo object>",
  "forCapture": false,
  "renderWindow": "<RenderWindow object>"
}
```

### Response
#### Success Response (Boolean)
Returns True when your render engine started correctly, False when that failed.

#### Response Example
```json
{
  "result": true
}
```

### Available since
6.0
```

--------------------------------

### RenderTextureTable.BeginChange Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendertexturetable/beginchange

Initiates a change context for rendering textures. This method belongs to the Rhino.Render.RenderTextureTable class.

```APIDOC
## BeginChange Method

### Description
Initiates a change context for rendering textures.

### Method
`public Void BeginChange(ChangeContexts changeContext)`

### Endpoint
Not applicable (this is a method documentation)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "changeContext": "SomeChangeContextValue" 
}
```

### Response
#### Success Response (Void)
This method does not return a value.

#### Response Example
None

### Remarks
- **Class**: `Rhino.Render.RenderTextureTable`
- **Available since**: `7.0`
```

--------------------------------

### Get Rhino Render Libraries Panel Guid (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/libraries

This property returns the unique identifier (Guid) for the Rhino Render Libraries panel within the Rhino UI. It is a static property and does not require an instance of PanelIds to be accessed. Available since version 5.9.

```csharp
public static Guid Libraries { get; }
```

--------------------------------

### Get Side Pane UI ID from Tab (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendertabs/sidepaneuiidfromtab

This C# method returns the Guid of the side pane UI containing the specified tab. It is available from version 8.0 of the RhinoCommon API. The input is an 'Object' representing the tab, and the output is a 'Guid'.

```csharp
public static Guid SidePaneUiIdFromTab(
  Object tab
)
```

--------------------------------

### File3dmTypeCodes Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmtypecodes/file3dmtypecodes

Initializes a new instance of the File3dmTypeCodes class.

```APIDOC
## File3dmTypeCodes()

### Description
Initializes a new instance of the File3dmTypeCodes class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Body
None

### Request Example
None

### Response
#### Success Response (N/A)
This is a constructor, it does not return a value in the traditional sense.

#### Response Example
None
```

--------------------------------

### Get All Layer IDs | Python

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Retrieves a list containing the unique identifiers (GUIDs) for all layers in the document. This function returns a list of strings, where each string is a layer's GUID. It's useful for programmatic access to layers when names might be ambiguous or change.

```python
import rhinoscriptsyntax as rs

layers = rs.LayerIds()
for layer in layers: print(layer)
```

--------------------------------

### Override Render Engine Start with StartRenderer (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.realtimedisplaymode/startrenderer

This method allows custom render engines to be integrated by overriding the default rendering process. It requires initializing the RenderWindow with SetSize before use. The method returns a boolean indicating success or failure.

```csharp
public abstract Boolean StartRenderer(
  Int32 w,
  Int32 h,
  RhinoDoc doc,
  ViewInfo view,
  ViewportInfo viewportInfo,
  Boolean forCapture,
  RenderWindow renderWindow
)
```

--------------------------------

### Rhino.DocObjects.SnapShots.SnapShotsClient.AnimationStart

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.snapshots.snapshotsclient/animationstart

Called once at the start of an animation. This method is part of the SnapShotsClient class within the Rhino.DocObjects.SnapShots namespace.

```APIDOC
## AnimationStart method

### Description
Called once at the start of an animation.

### Method
`public abstract Void AnimationStart`

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// Example usage within a C# context:
// SnapShotsClient client = ...;
// RhinoDoc doc = ...;
// int numFrames = 100;
// client.AnimationStart(doc, numFrames);
```

### Response
#### Success Response
* **Type**: Void
* **Description**: This method does not return a value.

#### Response Example
N/A
```

--------------------------------

### TextLog(string filename) Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.textlog/textlog

Creates a text log that writes all text to a file. If no filename is provided, then text is written to StdOut.

```APIDOC
## TextLog(string filename)

### Description
Creates a text log that writes all text to a file. If no filename is provided, then text is written to StdOut. This constructor is available from version 5.1.

### Method
GET

### Endpoint
/Rhino.FileIO/TextLog/TextLog(string)

### Parameters
#### Path Parameters
- **filename** (string) - Optional - The name of the file to create and write to. If null, then text output is sent to StdOut.

### Request Example
None

### Response
#### Success Response (200)
- **TextLog** (object) - An instance of the TextLog class.

#### Response Example
None
```

--------------------------------

### Add Line with Start and End Points (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmobjecttable/addline

Adds a line object to Rhino using specified start and end Point3d coordinates without attributes. It returns a Guid identifying the new rhino object. Available since version 5.0.

```csharp
public Guid AddLine(
  Point3d from,
  Point3d to
)
```

--------------------------------

### Initialize RhinoCore with Arguments (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.inprocess.rhinocore/rhinocore

Initializes a new instance of the RhinoCore class with specified command-line arguments. This constructor allows passing startup parameters directly. For more information on arguments, consult the C++ documentation. Available since Rhino 7.0.

```csharp
public RhinoCore(string[] args)

```

--------------------------------

### Add Line with Start and End Points and Attributes (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmobjecttable/addline

Adds a line object to Rhino using specified start and end Point3d coordinates, along with optional ObjectAttributes. It returns a Guid for the new object. Available since version 5.0.

```csharp
public Guid AddLine(
  Point3d from,
  Point3d to,
  ObjectAttributes attributes
)
```

--------------------------------

### RhinoCommon RenderContentType Constructor Syntax

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendercontenttype/rendercontenttype

This snippet shows the syntax for the RenderContentType constructor in RhinoCommon. It requires a Guid representing the type ID. The constructor is available starting from version 6.0.

```csharp
public RenderContentType(
  Guid typeId
)
```

--------------------------------

### SimpleArrayBrepPointer.Add

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.interopwrappers.simplearraybreppointer/add

Adds a brep to the list. This method is part of the Rhino.Runtime.InteropWrappers.SimpleArrayBrepPointer class.

```APIDOC
## SimpleArrayBrepPointer.Add

### Description
Adds a brep to the list.

### Method
Public Void

### Endpoint
N/A (Class Method)

### Parameters
#### Parameters
- **brep** (Geometry.Brep) - Required - A brep to add.
- **asConst** (System.Boolean) - Required - Whether this brep should be treated as non-modifiable.

### Returns
Type: Void

### Available since
5.0
```

--------------------------------

### RhinoCommon API: C# CommandLineOptions Example

Source: https://developer.rhino3d.com/api/rhinocommon/examples/commandlineoptions

Demonstrates how to use custom command line options with the GetPoint class in RhinoCommon using C#. It shows adding integer, double, boolean, and list options and retrieving their values after user input. Requires RhinoCommon library.

```csharp
partial class Examples
{
  public static Rhino.Commands.Result CommandLineOptions(Rhino.RhinoDoc doc)
  {
    // For this example we will use a GetPoint class, but all of the custom
    // "Get" classes support command line options.
    Rhino.Input.Custom.GetPoint gp = new Rhino.Input.Custom.GetPoint();
    gp.SetCommandPrompt("GetPoint with options");

    // set up the options
    Rhino.Input.Custom.OptionInteger intOption = new Rhino.Input.Custom.OptionInteger(1, 1, 99);
    Rhino.Input.Custom.OptionDouble dblOption = new Rhino.Input.Custom.OptionDouble(2.2, 0, 99.9);
    Rhino.Input.Custom.OptionToggle boolOption = new Rhino.Input.Custom.OptionToggle(true, "Off", "On");
    string[] listValues = new string[] { "Item0", "Item1", "Item2", "Item3", "Item4" };

    gp.AddOptionInteger("Integer", ref intOption);
    gp.AddOptionDouble("Double", ref dblOption);
    gp.AddOptionToggle("Boolean", ref boolOption);
    int listIndex = 3;
    int opList = gp.AddOptionList("List", listValues, listIndex);

    while (true)
    {
      // perform the get operation. This will prompt the user to input a point, but also
      // allow for command line options defined above
      Rhino.Input.GetResult get_rc = gp.Get();
      if (gp.CommandResult() != Rhino.Commands.Result.Success)
        return gp.CommandResult();

      if (get_rc == Rhino.Input.GetResult.Point)
      {
        doc.Objects.AddPoint(gp.Point());
        doc.Views.Redraw();
        Rhino.RhinoApp.WriteLine("Command line option values are");
        Rhino.RhinoApp.WriteLine(" Integer = {0}", intOption.CurrentValue);
        Rhino.RhinoApp.WriteLine(" Double = {0}", dblOption.CurrentValue);
        Rhino.RhinoApp.WriteLine(" Boolean = {0}", boolOption.CurrentValue);
        Rhino.RhinoApp.WriteLine(" List = {0}", listValues[listIndex]);
      }
      else if (get_rc == Rhino.Input.GetResult.Option)
      {
        if (gp.OptionIndex() == opList)
          listIndex = gp.Option().CurrentListOptionIndex;
        continue;
      }
      break;
    }
    return Rhino.Commands.Result.Success;
  }
}
```

--------------------------------

### Get Installed Fonts as FontQuartets (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.font/installedfontsasquartets

The InstalledFontsAsQuartets method returns an array of FontQuartet objects, representing all fonts installed on the system and available for use within Rhino. This method is part of the Rhino.DocObjects.Font class and has been available since version 6.7.

```csharp
public static FontQuartet[] InstalledFontsAsQuartets()
{
    // Implementation details return available fonts
    return new FontQuartet[0];
}
```

--------------------------------

### Access NotesInStartSection Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileigswriteoptions/notesinstartsection

This snippet demonstrates how to get or set the NotesInStartSection property for IGS file writing options. This property determines if notes are written to the start section of the IGS file. It is a boolean value and is available starting from Rhino version 8.0.

```csharp
public bool NotesInStartSection {get|set}
```

--------------------------------

### IndexPair Struct Documentation

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_IndexPair

Provides detailed information about the IndexPair struct, including its constructors, properties, and methods.

```APIDOC
## IndexPair Struct

### Description
Represents two indices: I and J.

### Derived Classes
Namespace:Rhino
_IndexPair:references_

### Constructors (1)
#### IndexPair(int i, int j)
Initializes a new instance of **IndexPair** with two indices.

### Properties (4)
#### Count
Returns the amount of elements in this pair of indices, which is always 2.

#### I
Gets or sets the first, I index.

#### Item
Gets or sets a particular index of this structure. Only 0 and 1 are valid indices.

#### J
Gets or sets the second, J index.

### Methods (4)
#### Contains(Int32 item)
Determines whether the **IndexPair** contains a specific value.

#### CopyTo(Int32[] array, Int32 arrayIndex)
Copies the elements of the **IndexPair** to an T:System.Array , starting at a particular T:System.Array index.

#### GetEnumerator()
Gets an enumerator that goes over I and J , in this order.

#### IndexOf(Int32 item)
Determines the index of a specific item in **IndexPair** .
```

--------------------------------

### Read3dmStartSection Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.binaryarchivereader/read3dmstartsection

Reads the start section of a .3dm file, extracting the version and comment information.

```APIDOC
## Read3dmStartSection Method

### Description
Reads the start section of a .3dm file and retrieves the file version and associated comment string.

### Method
`public Boolean Read3dmStartSection(out Int32 version, out String comment)`

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
Boolean success = reader.Read3dmStartSection(out int version, out string comment);
```

### Response
#### Success Response (Boolean)
- **version** (Int32) - The .3dm file version (e.g., 2, 3, 4, 5, or 50).
- **comment** (String) - A string containing application name, version, compile date, and OS information.

#### Response Example
```json
{
  "version": 5,
  "comment": "Rhino 7 SR25 7.25.23090.1001, Windows"
}
```

### Availability
- Available since: 5.1
```

--------------------------------

### Get or Set Start Year for Sun Animation (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.animationproperties/startyear

This property retrieves or modifies the starting year for seasonal or one-day sun animations within the Rhino 3D environment. The valid range for the year is between 1800 and 2199. It is part of the AnimationProperties class in the Rhino.DocObjects namespace.

```csharp
public int StartYear {get|set}
```

--------------------------------

### Get or Set View Rotation Style (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.viewsettings/viewrotation

The ViewRotation property in Rhino.ApplicationSettings.ViewSettings allows you to get or set the view rotation style. This property returns a ViewRotationStyle enum value and is available starting from Rhino version 8.1. It does not accept any parameters for setting the value.

```csharp
public static ViewRotationStyle ViewRotation { get; set; }
```

--------------------------------

### ObjectPropertiesPage Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.objectpropertiespage/objectpropertiespage

Initializes a new instance of the ObjectPropertiesPage class.

```APIDOC
## ObjectPropertiesPage()

### Description
Initializes a new instance of the ObjectPropertiesPage class.

### Method
CONSTRUCTOR

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "ObjectPropertiesPage()"
}
```

### Response
#### Success Response (Constructor)
- **Instance** (ObjectPropertiesPage) - A new instance of the ObjectPropertiesPage class.

#### Response Example
```json
{
  "example": "// Creates a new ObjectPropertiesPage instance"
}
```
```

--------------------------------

### Get Plug-in Description (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugininfo/description

Retrieves the description of a plug-in using the Description property of the PlugInInfo class. This property returns a string representing the plug-in's description and is available starting from Rhino version 6.0.

```csharp
public string Description { get; }
```

--------------------------------

### Load Installed Plug-in (with quiet and force options)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/loadplugin

Loads an installed plug-in using its unique identifier. This overload provides options to load the plug-in quietly and to force the load even if previous attempts failed. It returns a boolean indicating success.

```csharp
public static Boolean LoadPlugIn(
  Guid pluginId,
  Boolean loadQuietly,
  Boolean forceLoad
)
```

--------------------------------

### Get and Set Command Prompt Font Size (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.appearancesettingsstate/commandpromptfontsize

This property allows you to get or set the font size (in points) used in the Rhino command prompt. It returns an integer value representing the font size. This functionality is available starting from Rhino version 7.0.

```csharp
public int CommandPromptFontSize {get|set}
```

--------------------------------

### VolumeMassProperties Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.volumemassproperties/volumemassproperties

Initializes a new instance of the VolumeMassProperties class.

```APIDOC
## VolumeMassProperties()

### Description
Initializes a new instance of the VolumeMassProperties class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Instance)
- **VolumeMassProperties** (VolumeMassProperties) - A new instance of the VolumeMassProperties class.

#### Response Example
```json
{
  "instance": "new VolumeMassProperties object"
}
```
```

--------------------------------

### SerializationOptions.MinRhinoVersion

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.serializationoptions/minrhinoversion

Gets the earliest serialization version available.

```APIDOC
## SerializationOptions.MinRhinoVersion

### Description
Gets the earliest serialization version available.

### Method
GET (Property Access)

### Endpoint
N/A (Property)

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
- **Return Value** (int) - The minimum serialization version number.

#### Response Example
```json
{
  "returnValue": 8
}
```
```

--------------------------------

### ZooClientParameters.ProductPath

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.zooclientparameters/productpath

Gets the path to the application that is calling ZooClient.

```APIDOC
## ZooClientParameters.ProductPath

### Description
Gets the path to the application that is calling ZooClient.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Runtime/ZooClientParameters/ProductPath

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **ProductPath** (string) - The path to the application calling ZooClient.

#### Response Example
{
  "ProductPath": "/path/to/your/application"
}
```

--------------------------------

### RhinoCore(string[] args, WindowStyle windowStyle, IntPtr hostWnd) Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.inprocess.rhinocore/rhinocore

Initializes a new instance of the RhinoCore class with specified command-line arguments, window style, and host window handle.

```APIDOC
## RhinoCore(string[] args, WindowStyle windowStyle, IntPtr hostWnd)

### Description
Initializes a new instance of the RhinoCore class with command-line arguments, a specific window style, and a handle to the host window.

### Method
`public RhinoCore(string[] args, WindowStyle windowStyle, IntPtr hostWnd)`

### Endpoint
N/A (Constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Parameters
*   **args** (System.String[]) - Rhino command line parameters. For documentation, see "https://developer.rhino3d.com/guides/cpp/running-rhino-from-command-line/"
*   **windowStyle** (WindowStyle) - Rhino main window initial style.
*   **hostWnd** (System.IntPtr) - Host main window OS native handle.

### Request Example
```csharp
// Assuming appropriate values for args, windowStyle, and hostWnd
IntPtr mainWindowHandle = ...; // Get the handle of your host window
string[] rhinoArgs = {" /silent "};
WindowStyle style = WindowStyle.Normal;

var rhinoCore = new RhinoCore(rhinoArgs, style, mainWindowHandle);
```

### Response
#### Success Response
Initializes the RhinoCore instance with the provided configuration.

#### Response Example
N/A (Constructor)
```

--------------------------------

### RenderEngineId Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.customrendercontentattribute/renderengineid

The RenderEngineId property of the CustomRenderContentAttribute class allows you to get or set the unique identifier for the render engine associated with this content attribute. This property returns a Guid.

```APIDOC
## RenderEngineId Property

### Description
Gets or sets the unique identifier (Guid) for the render engine associated with this custom render content attribute.

### Syntax
```csharp
public Guid RenderEngineId { get; set; }
```

### Returns
Type: `System.Guid` - The unique identifier of the render engine.

### Available since
RhinoCommon 6.0
```

--------------------------------

### HermiteSurface.SetUParameterAt Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.hermitesurface/setuparameterat

This method sets the 'u' parameter at a specified index within a HermiteSurface. The 'u' parameters are strictly increasing.

```APIDOC
## SetUParameterAt Method

### Description
Sets the 'u' parameter at a specified index within a HermiteSurface. The 'u' parameters are strictly increasing.

### Method
public Void SetUParameterAt(Int32 index, Double parameter)

### Endpoint
N/A (This is a class method within the RhinoCommon library)

### Parameters
#### Path Parameters
N/A

#### Query Parameters
N/A

#### Request Body
N/A

### Request Example
```csharp
// Example usage (assuming you have a HermiteSurface object named 'surface')
int indexToSet = 0;
double parameterValue = 0.5;
surface.SetUParameterAt(indexToSet, parameterValue);
```

### Response
#### Success Response (Void)
This method does not return a value.

#### Response Example
N/A
```

--------------------------------

### GetPointOnMesh (RhinoDoc, Guid, String, Boolean, out Point3d)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.rhinoget/getpointonmesh

Gets a point constrained to an existing mesh in the document using the mesh's ID.

```APIDOC
## GET /api/mesh/{meshObjectId}/getpointonmesh

### Description
Gets a point constrained to an existing mesh in the document.

### Method
GET

### Endpoint
/api/mesh/{meshObjectId}/getpointonmesh

### Parameters
#### Path Parameters
- **meshObjectId** (Guid) - Required - An ID of a mesh in the document.
- **doc** (RhinoDoc) - Required - Document containing mesh object.
- **prompt** (String) - Required - Text prompt.
- **acceptNothing** (Boolean) - Required - True if nothing else should be accepted.

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "meshObjectId": "a1b2c3d4-e5f6-7890-1234-567890abcdef",
  "doc": "<rhino_document_representation>",
  "prompt": "Select a point on the mesh",
  "acceptNothing": false
}
```

### Response
#### Success Response (200)
- **point** (Point3d) - A point value will be assigned to this out parameter during this call.
- **Result** (Result) - A command result based on user choice.

#### Response Example
```json
{
  "point": {
    "x": 1.0,
    "y": 2.0,
    "z": 3.0
  },
  "Result": "Success"
}
```
```

--------------------------------

### IntersectionEvent.ParameterB Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.intersect.intersectionevent/parameterb

Gets the parameter on Curve B where the intersection occurred. If the intersection type is overlap, then this will return the start of the overlap region.

```APIDOC
## IntersectionEvent.ParameterB Property

### Description
Gets the parameter on Curve B where the intersection occurred. If the intersection type is overlap, then this will return the start of the overlap region.

### Method
Get

### Endpoint
N/A (This is a property, not an endpoint)

### Parameters
None

### Request Example
```json
{
  "example": "Not applicable for property access"
}
```

### Response
#### Success Response (200)
- **ParameterB** (double) - The parameter on Curve B at the intersection point.

#### Response Example
```json
{
  "ParameterB": 1.2345
}
```
```

--------------------------------

### ShowContentInstanceBrowser Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendercontent/showcontentinstancebrowser

Displays the Content Instance Browser dialog to allow the user to choose a content. The dialog includes OK, Cancel, and Help buttons, with optional New and Edit buttons. It specifies the document to use, sets the initially selected content, and receives the instance ID of the chosen content. It also specifies the kind(s) of content to display and which optional buttons to show. Returns true if the user selects content, false if the dialog is cancelled.

```APIDOC
## ShowContentInstanceBrowser Method

### Description
Allows the user to choose a content by displaying the Content Instance Browser dialog. The dialog will have OK, Cancel and Help buttons, and optional New and Edit buttons. Specifies the document to use. Sets the initially selected content and receives the instance id of the chosen content. Specifies the kind(s) of content that should be displayed in the browser. Specifies which optional buttons to display. Returns True if the user chooses a content or False if the dialog is cancelled.

### Method
`public static Boolean ShowContentInstanceBrowser(
  RhinoDoc doc, 
  ref Guid instance_id, 
  RenderContentKind kinds, 
  ContentInstanceBrowserButtons buttons 
)`

### Parameters
#### Path Parameters
* None

#### Query Parameters
* None

#### Request Body
* None

### Request Example
```json
{
  "doc": "RhinoDoc object",
  "instance_id": "System.Guid",
  "kinds": "RenderContentKind enum value",
  "buttons": "ContentInstanceBrowserButtons enum value"
}
```

### Response
#### Success Response (Boolean)
* Returns `True` if the user chooses a content, `False` if the dialog is cancelled.

#### Response Example
```json
{
  "returnValue": true
}
```

### Available since
8.15
```

--------------------------------

### CreatePlanarUnion (IEnumerable<Brep>)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createplanarunion

Creates a planar union from a collection of Breps lying on a specified plane with a given tolerance.

```APIDOC
## POST /api/brep/createPlanarUnion/many

### Description
Creates a planar union from a collection of Breps that lie on a specified plane, using a given tolerance for the operation.

### Method
POST

### Endpoint
/api/brep/createPlanarUnion/many

### Parameters
#### Request Body
- **breps** (IEnumerable<Brep>) - Required - The collection of planar regions on which to perform the union operation.
- **plane** (Plane) - Required - The plane in which all input Breps lie.
- **tolerance** (System.Double) - Required - Tolerance to use for the union operation.

### Request Example
```json
{
  "breps": [
    { /* Brep object 1 */ },
    { /* Brep object 2 */ }
  ],
  "plane": { /* Plane object */ },
  "tolerance": 0.01
}
```

### Response
#### Success Response (200)
- **Brep[]** - An array of Brep results or null on failure.

#### Response Example
```json
[
  { /* Brep object 1 */ },
  { /* Brep object 2 */ }
]
```
```

--------------------------------

### Get Installed Fonts by Family Name (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.font/installedfonts

Retrieves an array of fonts installed on the system that are recognized by Rhino, filtered by a specific font family name. This overload allows users to search for fonts belonging to a particular family, such as 'Arial' or 'Times New Roman'.

```csharp
public static Font[] InstalledFonts(String familyName)
{
  // Implementation details to retrieve installed fonts by family name
  throw new NotImplementedException();
}
```

--------------------------------

### RhinoAccountsManager() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.rhinoaccounts.rhinoaccountsmanager/rhinoaccountsmanager

Initializes a new instance of the RhinoAccountsManager class.

```APIDOC
## RhinoAccountsManager()

### Description
Initializes a new instance of the RhinoAccountsManager class.

### Method
Constructor

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
```
// No request body for a constructor
```

### Response
#### Success Response (Instance)
- **RhinoAccountsManager** (Rhino.Runtime.RhinoAccounts.RhinoAccountsManager) - An initialized instance of the RhinoAccountsManager class.

#### Response Example
```json
{
  "instance": "<RhinoAccountsManager instance>"
}
```
```

--------------------------------

### NurbsSurface Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_NurbsSurface

Provides information about the different ways to construct a NurbsSurface object.

```APIDOC
## NurbsSurface Constructors

### Description
These constructors allow for the creation of NurbsSurface objects, either by copying existing surfaces or through internal initialization.

### Constructors

- **NurbsSurface()**: Allows construction from inheriting classes.
- **NurbsSurface(SerializationInfo info, StreamingContext context)**: Protected constructor for internal use.
- **NurbsSurface(NurbsSurface other)**: Initializes a new NURBS surface by copying the values from another surface.
- **Surface()**: Protected constructor for internal use.
- **Surface(SerializationInfo info, StreamingContext context)**: Protected constructor for internal use.
- **GeometryBase(SerializationInfo info, StreamingContext context)**: Protected constructor for internal use.
- **CommonObject()**: Allows construction from inheriting classes.
- **CommonObject(SerializationInfo info, StreamingContext context)**: Protected constructor for internal use.
```

--------------------------------

### Get EventType (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.addcustomuisectionseventargs/eventtype

Retrieves the Guid representing the type of the event. This property is read-only and provides information about the specific event that has occurred within the Rhino.Render system.

```csharp
public Guid EventType { get; }
```

--------------------------------

### Get RightToLeftScale Value (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.scalevalue/righttoleftscale

Retrieves the double value representing the right-to-left scale. This property is available starting from RhinoCommon version 6.0.

```csharp
public double RightToLeftScale { get; }
```

--------------------------------

### Get PageRelativeTolerance in C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinodoc/pagerelativetolerance

Retrieves the page space relative tolerance from a Rhino document. This property is of type double and is available starting from Rhino version 5.0.

```csharp
double tolerance = doc.PageRelativeTolerance;
```

--------------------------------

### Rhino.Render.PreviewAppearance.CppPointer

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewappearance/cpppointer

Retrieves the C++ pointer for a PreviewAppearance object.

```APIDOC
## Rhino.Render.PreviewAppearance.CppPointer

### Description
Retrieves the C++ pointer for a PreviewAppearance object. This property is useful for interoperability with C++ code.

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Render/PreviewAppearance/CppPointer

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "No request body needed for this property."
}
```

### Response
#### Success Response (200)
- **IntPtr** (IntPtr) - The C++ pointer to the PreviewAppearance object.

#### Response Example
```json
{
  "example": "0xabcdef1234567890"
}
```

### Remarks
Available since Rhino version 6.0.
```

--------------------------------

### InitialChannelToDisplay Property Syntax (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.renderplugin/initialchanneltodisplay

This snippet shows the C# syntax for the protected virtual Guid InitialChannelToDisplay property. It is a getter-only property that returns a Guid.

```csharp
protected virtual Guid InitialChannelToDisplay { get; }
```

--------------------------------

### StartLongitude Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.decalcreateparams/startlongitude

The StartLongitude property of the DecalCreateParams class allows you to get or set the starting longitude for a decal. This property is of type double and was introduced in version 6.0 of the RhinoCommon API.

```APIDOC
## StartLongitude Property

### Description

Gets or sets the starting longitude for a decal.

### Method

get | set

### Endpoint

Rhino.Render.DecalCreateParams.StartLongitude

### Parameters

#### Path Parameters

None

#### Query Parameters

None

#### Request Body

None

### Request Example

```json
{
  "example": "Not applicable for property access"
}
```

### Response

#### Success Response (200)

- **Type** (double) - The starting longitude value.

#### Response Example

```json
{
  "example": "10.5"
}
```

### Remarks

Available since RhinoCommon version 6.0.
```

--------------------------------

### RhinoViewport Constructor (default)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.rhinoviewport/rhinoviewport

Initializes a new instance of the RhinoViewport class with default settings.

```APIDOC
## RhinoViewport (default constructor)

### Description
Initializes a new instance of the RhinoViewport class with default settings.

### Method
`public`

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (N/A)
N/A

#### Response Example
N/A

### Available since
5.0
```

--------------------------------

### RenderPreCreateWindow Method Syntax (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderpipeline/renderprecreatewindow

Provides the C# syntax for the RenderPreCreateWindow method within the Rhino.Render.RenderPipeline class. This method is protected and virtual, returning a Boolean value.

```csharp
protected virtual Boolean RenderPreCreateWindow()
```

--------------------------------

### Get CommandLineOption Type

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.commandlineoption/optiontype

Retrieves the type of a command line option. This property returns a value of type CommandLineOptionType and is available starting from Rhino version 8.0.

```csharp
public CommandLineOptionType OptionType {get}
```

--------------------------------

### FileUsd Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileusd/fileusd

Initializes a new instance of the FileUsd class.

```APIDOC
## FileUsd()

### Description
Initializes a new instance of the FileUsd class.

### Method
Constructor

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "FileUsd()"
}
```

### Response
#### Success Response (Instance)
- **FileUsd** (FileUsd) - An instance of the FileUsd class.

#### Response Example
```json
{
  "example": "(Instance of FileUsd)"
}
```
```

--------------------------------

### M30 Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.transform/m30

Gets or sets a double value representing a component of the transform matrix. This property is part of the Rhino.Geometry.Transform class and is available starting from version 5.0.

```APIDOC
## M30 Property

### Description
Gets or sets a double value.

### Class
Rhino.Geometry.Transform

### Method
`get` or `set`

### Type
double

### Available since
5.0

### Syntax
```csharp
public double M30 {get|set}
```
```

--------------------------------

### SetUpperLimit Method in C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getinteger/setupperlimit

The SetUpperLimit method is part of the Rhino.Input.Custom.GetInteger class. It takes an integer 'upperLimit' and a boolean 'strictlyLessThan' to define the boundary for returned numbers. This method is available since version 5.0.

```csharp
public Void SetUpperLimit(  
Int32 upperLimit,   
Boolean strictlyLessThan  
)
```

--------------------------------

### Get MiterPlaneNormalAtStart (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.extrusion/miterplanenormalatstart

Retrieves the normal vector of the miter plane at the start of an extrusion in profile coordinates. This property returns a Vector3d object representing the normal.

```csharp
public Vector3d MiterPlaneNormalAtStart { get; }
```

--------------------------------

### Get Point at Arc Length on Curve in Python

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Calculates and returns a point on a curve at a specified arc length from either the start or end of the curve. It takes the curve identifier, the desired arc length, and an optional boolean to specify the direction from the start. Returns the point on the curve if successful.

```python
import rhinoscriptsyntax as rs

obj = rs.GetObject("Select a curve")
if rs.IsCurve(obj):
    length = rs.CurveLength(obj)
    point = rs.CurveArcLengthPoint(obj, length/3.0)
    rs.AddPoint( point )
```

--------------------------------

### Get and Set ShadowsIgnoreUserDefinedClippingPlanes (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaypipelineattributes/shadowsignoreuserdefinedclippingplanes

This property allows you to get or set whether shadows should ignore user-defined clipping planes in the display pipeline. It's a boolean value, returning true if shadows ignore clipping planes, and false otherwise. This feature is available starting from RhinoCommon version 8.11.

```csharp
public bool ShadowsIgnoreUserDefinedClippingPlanes { get; set; }
```

--------------------------------

### Rhino.Render.LightManagerSupportClient.CppPointer

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.lightmanagersupportclient/cpppointer

Retrieves the native C++ pointer for the LightManagerSupportClient instance. This is useful for interoperability with C++ code.

```APIDOC
## CppPointer Property

### Description
Gets the native C++ pointer for the `LightManagerSupportClient` instance. This property is primarily used for interoperability with C++ code that requires direct memory access or interaction with the underlying C++ object.

### Class
Rhino.Render.LightManagerSupportClient

### Syntax
```csharp
public IntPtr CppPointer { get; }
```

### Returns
- **IntPtr**: An `IntPtr` representing the memory address of the native C++ object.

### Available since
6.0
```

--------------------------------

### Initialize FileTxtReadOptions Instance (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filetxtreadoptions/filetxtreadoptions

This snippet shows how to create a new instance of the FileTxtReadOptions class. This class is used to define settings for reading text files, such as delimiter types or encoding. No specific dependencies are required beyond the RhinoCommon library itself.

```csharp
Rhino.FileIO.FileTxtReadOptions options = new Rhino.FileIO.FileTxtReadOptions();
```

--------------------------------

### Get Original Instance IDs from Texture ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.changequeue.changequeue/originalinstanceidsfromtextureid

Retrieves an array of Guid objects representing the original document instance IDs associated with a given Texture ID. This method is part of the Rhino.Render.ChangeQueue.ChangeQueue class. It takes a UInt32 CRC value as input and returns an array of Guid.

```csharp
public Guid[] OriginalInstanceIdsFromTextureId(
  UInt32 crc
)
```

--------------------------------

### Get Active Plug-in Version Folders (Default)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/getactivepluginversionfolders

Recurses through auto-install plug-in folders to return directories containing 'active' plug-in versions. If a package exists in both user and machine locations, the newest directory is returned. This method considers both user and machine installations by default.

```csharp
public static System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> GetActivePlugInVersionFolders()
{
  // Implementation details omitted for brevity
  return null;
}
```

--------------------------------

### Get Installed Rhino Plug-in Names (Filtered by Type and Load State)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getinstalledpluginnames

Retrieves a list of installed Rhino plug-in names, allowing filtering by plug-in type and their load state (loaded or unloaded). This overload is useful when the localization of plug-in names is not a concern. Available since RhinoCommon 5.0.

```csharp
public static String[] GetInstalledPlugInNames(
  PlugInType typeFilter,
  Boolean loaded,
  Boolean unloaded
)
{
  // Parameters:
  // * typeFilter: Enumeration flags for plug-in types.
  // * loaded: True to include loaded plug-ins.
  // * unloaded: True to include unloaded plug-ins.
  // Returns: An array of installed plug-in names (can be empty, but not null).
}
```

--------------------------------

### Display Help for a Command (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.commands.command/displayhelp

This C# code snippet demonstrates how to use the DisplayHelp method from the Rhino.Commands.Command class. It requires a System.Guid representing the command ID as input. The method returns void and does not produce any direct output other than displaying the help information.

```csharp
using System;

// Assuming commandId is a valid Guid for a Rhino command
Guid commandId = new Guid("YOUR_COMMAND_ID_HERE"); 

Rhino.Commands.Command.DisplayHelp(commandId);
```

--------------------------------

### Construct Geodesic Curve (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.surface/shortpath

Constructs a geodesic curve between two points on a surface using the RhinoCommon API. This C# example demonstrates how to use the ShortPath method, specifying start and end points in parameter space and a tolerance for fitting the solution.

```csharp
public Curve ShortPath(
  Point2d start, 
  Point2d end, 
  Double tolerance
)
```

--------------------------------

### Get Light ID using RhinoCommon API (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.light/id

This C# snippet demonstrates how to access the unique Guid identifier of a light object using the RhinoCommon API. It requires an instance of the Light class. The returned value is a Guid representing the light's ID.

```csharp
using Rhino.Geometry;

// Assuming 'myLight' is an instance of the Light class
Guid lightId = myLight.Id;
System.Console.WriteLine("Light ID: " + lightId.ToString());
```

--------------------------------

### ConvertibleExtensions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.convertibleextensions/convertibleextensions

Initializes a new instance of the ConvertibleExtensions class.

```APIDOC
## ConvertibleExtensions()

### Description
Initializes a new instance of the ConvertibleExtensions class.

### Method
CONSTRUCTOR

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Body
None

### Request Example
```
// No request body for a constructor
```

### Response
#### Success Response (Instance)
- **ConvertibleExtensions** (object) - A new instance of the ConvertibleExtensions class.

#### Response Example
```json
{
  "message": "Instance of ConvertibleExtensions created successfully."
}
```
```

--------------------------------

### AddOption (overload 5)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getbaseclass/addoption

Adds a command line option with an English name and an English value.

```APIDOC
## POST /AddOption

### Description
Adds a command line option with an English name and an English value.

### Method
POST

### Endpoint
/AddOption

### Parameters
#### Request Body
- **englishOption** (String) - Required - Must only consist of letters and numbers (no characters list periods, spaces, or dashes).
- **englishOptionValue** (String) - Required - The option value in English, visualized after an equality sign.

### Response
#### Success Response (200)
- **return_value** (Int32) - Option index value (>0) or 0 if option cannot be added.

Available since: 5.0
```

--------------------------------

### Get Rhino 7 ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/rhino7id

Retrieves the unique Guid identifier for Rhino 7. This property is read-only and was introduced in version 7.3 of the RhinoCommon API.

```csharp
public static Guid Rhino7Id {get}
```

--------------------------------

### Get HueSatLum Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectuuids/huesatlum

Retrieves the Guid representing the HueSatLum post-effect. This property is static and part of the Rhino.Render.PostEffects.PostEffectUuids class. It is available since version 8.13.

```csharp
public static Guid HueSatLum {get}
```

--------------------------------

### RhinoList<T> Constructors

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.collections

Provides details on how to initialize a new RhinoList<T> instance.

```APIDOC
## RhinoList<T> Constructors

### Description
Initializes a new instance of the RhinoList<T> class.

### Constructors

- **RhinoList<T>()**
  Initializes a new, empty list.

- **RhinoList<T>(IEnumerable<T> collection)**
  Initializes this list as a shallow duplicate of another list, array, or any other enumerable set of T.

- **RhinoList<T>(int amount, T defaultValue)**
  Initializes a new list with a specified amount of values.

- **RhinoList<T>(int initialCapacity)**
  Initializes an empty list with a certain capacity.

- **RhinoList<T>(RhinoList<T> list)**
  Initializes a new list by shallow duplicating another list.
```

--------------------------------

### Initialize RhinoCore with Arguments, Window Style, and Host Window Handle (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.inprocess.rhinocore/rhinocore

Initializes a new instance of the RhinoCore class with command-line arguments, window style, and a host window handle. This is useful for embedding Rhino within another application's window. Refer to the C++ guide for argument details. Available since Rhino 7.0.

```csharp
public RhinoCore(
  string[] args,
  WindowStyle windowStyle,
  IntPtr hostWnd
)

```

--------------------------------

### Get RenderingId (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectpipeline/renderingid

Retrieves a unique Guid that identifies the current rendering process. This property is read-only and available since Rhino version 7.0.

```csharp
public Guid RenderingId { get; }
```

--------------------------------

### FilePlyReadOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileplyreadoptions/fileplyreadoptions

Initializes a new instance of the FilePlyReadOptions class.

```APIDOC
## FilePlyReadOptions Constructor

### Description
Initializes a new instance of the FilePlyReadOptions class.

### Method
Constructor

### Endpoint
N/A (Constructor)

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{
  "example": "FilePlyReadOptions()"
}
```

### Response
#### Success Response (Instance)
- **Instance** (FilePlyReadOptions) - A new instance of the FilePlyReadOptions class.

#### Response Example
```json
{
  "example": "A new FilePlyReadOptions object is created."
}
```
```

--------------------------------

### Get BlendMaterialCCI Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/blendmaterialcci

Retrieves the static Guid value for the BlendMaterialCCI. This property is read-only and is part of the Rhino.Render.ContentUuids class. It is available from RhinoCommon version 6.0 onwards.

```csharp
public static Guid BlendMaterialCCI { get; }
```

--------------------------------

### Get Clipped Viewport IDs (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.clippingplanesurface/viewportids

Retrieves an array of GUIDs representing RhinoViewports clipped by a ClippingPlaneSurface. This method is available from RhinoCommon version 5.0 onwards.

```csharp
public Guid[] ViewportIds()
{
  // Implementation details not provided in the source text
  return new Guid[0];
}
```

--------------------------------

### PushPullExtend

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Brep

Transforms a planar Brep face and recomputes adjacent faces if they are also planar, simulating the PushPull command's extend mode.

```APIDOC
## PushPullExtend

### Description
If the brep.Faces[faceIndex] is planar, and all the adjacent faces are planar, this function transforms brep.Faces[faceIndex] with the transform parameter and recomputes the adjacent faces. See the PushPull commands extend mode.

### Method
POST (or similar)

### Endpoint
`/PushPullExtend`

### Parameters
#### Path Parameters
None

#### Query Parameters
- **faceIndex** (Int32) - Required - The index of the face to transform.
- **tolerance** (Double) - Required - The tolerance for recomputing adjacent faces.

#### Request Body
- **transform** (Transform) - Required - The transformation to apply to the face.

### Request Example
```json
{
  "faceIndex": 0,
  "tolerance": 0.01,
  "transform": {
    "matrix": [
      [1, 0, 0, 0],
      [0, 1, 0, 0],
      [0, 0, 1, 0],
      [0, 0, 0, 1]
    ]
  }
}
```

### Response
#### Success Response (200)
- **success** (Boolean) - Indicates if the operation was successful.

#### Response Example
```json
{
  "success": true
}
```
```

--------------------------------

### Get File3dmRenderContent TypeId (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmrendercontent/typeid

Retrieves the unique Guid identifier for the content type of a File3dmRenderContent object. This property is read-only and part of the RhinoCommon API.

```csharp
public Guid TypeId {get}
```

--------------------------------

### ShowComboListBox Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.irhinouidialogservice/showcombolistbox

Displays a combo list box dialog to the user, allowing them to select an item from a provided list.

```APIDOC
## protected Object ShowComboListBox(String title, String message, IList items)

### Description
Displays a combo list box dialog to the user with a specified title, message, and a list of items to choose from.

### Method
protected

### Endpoint
Rhino.UI.IRhinoUiDialogService/ShowComboListBox

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **title** (String) - Required - The title of the dialog box.
- **message** (String) - Required - The message displayed above the list of items.
- **items** (IList) - Required - A list of strings representing the items to display in the combo box.

### Request Example
```json
{
  "title": "Select an Option",
  "message": "Please choose one of the following:",
  "items": ["Option 1", "Option 2", "Option 3"]
}
```

### Response
#### Success Response (200)
- **Object** (Object) - The selected item from the list, or null if the dialog was canceled.

#### Response Example
```json
{
  "selectedItem": "Option 2"
}
```
```

--------------------------------

### FileTxtWriteOptions.ToDictionary

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filetxtwriteoptions/todictionary

Creates a dictionary of options available in FileTxtWriteOptions. This dictionary can be passed to the RhinoDoc.Export function.

```APIDOC
## FileTxtWriteOptions.ToDictionary

### Description
Creates a dictionary of these options. This dictionary can be passed to the RhinoDoc.Export function.

### Method
public ArchivableDictionary ToDictionary()

### Endpoint
Rhino.FileIO/FileTxtWriteOptions/ToDictionary

### Parameters
None

### Request Example
```json
{}
```

### Response
#### Success Response (200)
- **ArchivableDictionary** (Type) - A dictionary containing the export options.

#### Response Example
```json
{
  "example": "ArchivableDictionary"
}
```
```

--------------------------------

### Get NamedViewId Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.viewinfo/namedviewid

Retrieves a unique identifier for a named view. If the view is not named, an empty Guid is returned. This property is read-only.

```csharp
public Guid NamedViewId { get; }
```

--------------------------------

### Get PlugInId Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.materialref/pluginid

Retrieves the unique identifier for a rendering plug-in associated with a MaterialRef object. This property is of type Guid and was introduced in version 5.10.

```csharp
public Guid PlugInId {get|set}
```

--------------------------------

### LengthMassProperties() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.lengthmassproperties/lengthmassproperties

Initializes a new, default instance of the LengthMassProperties class.

```APIDOC
## LengthMassProperties()

### Description
Initializes a new instance of the LengthMassProperties class with default values.

### Method
`public LengthMassProperties()`

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
```csharp
Rhino.Geometry.LengthMassProperties lengthMassProperties = new Rhino.Geometry.LengthMassProperties();
```

### Response
#### Success Response
Initializes a new instance of the LengthMassProperties class.

#### Response Example
```json
{
  "Example": "Instance of LengthMassProperties"
}
```
```

--------------------------------

### Get PreviewGeometry in RhinoCommon API

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewappearance/geometry

The Geometry() method in the Rhino.Render.PreviewAppearance class returns a PreviewGeometry object. This method is available starting from RhinoCommon version 6.0.

```csharp
public PreviewGeometry Geometry()

```

--------------------------------

### List All Layer Names

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

This example retrieves and prints the names of all layers present in the Rhino document. The 'sort' parameter can be used to get a sorted list. Uses the rhinoscriptsyntax library.

```python
import rhinoscriptsyntax as rs

layers = rs.LayerNames()
if layers:
    for layer in layers:
        print(layer)
```

--------------------------------

### Get Median Line (Triangle3d.MedianA)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.triangle3d/mediana

Retrieves the median line of a Triangle3d object that starts at corner A. This property returns a Line object representing the median.

```csharp
public Line MedianA { get; }
```

--------------------------------

### SetUpperLimit Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getnumber/setupperlimit

Sets an upper limit on the number that can be returned. By default, there is no upper limit.

```APIDOC
## SetUpperLimit Method

### Description
Sets an upper limit on the number that can be returned. By default, there is no upper limit.

### Method
public Void SetUpperLimit(Double upperLimit, Boolean strictlyLessThan)

### Endpoint
Rhino.Input.Custom.GetNumber.SetUpperLimit

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
This method does not take a request body.

### Request Example
```json
{
  "upperLimit": 100.5,
  "strictlyLessThan": true
}
```

### Response
#### Success Response (200)
This method returns void.

#### Response Example
```json
{
  "message": "Operation successful"
}
```
```

--------------------------------

### Get Rectangle3d Height (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.rectangle3d/height

Retrieves the signed height of a Rectangle3d object. The height is a double-precision floating-point number. This property is available starting from RhinoCommon version 5.0.

```csharp
public double Height {get}
```

--------------------------------

### Rhino.Render.PreviewBackground Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewbackground/previewbackground

Documentation for the constructor of the PreviewBackground class.

```APIDOC
## PreviewBackground constructor

### Description
Constructor for PreviewBackground.

### Method
public

### Endpoint
N/A (Class constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "// No request body for constructor"
}
```

### Response
#### Success Response (Constructor)
N/A (Constructors do not return a response in the typical API sense)

#### Response Example
```json
{
  "example": "// No response body for constructor"
}
```

### Remarks
Available since: 6.0
```

--------------------------------

### IntersectionEvent.PointB Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.intersect.intersectionevent/pointb

Gets the point on Curve B (or Surface B) where the intersection occurred. If the intersection type is overlap, then this will return the start of the overlap region.

```APIDOC
## IntersectionEvent.PointB Property

### Description
Gets the point on Curve B (or Surface B) where the intersection occurred. If the intersection type is overlap, then this will return the start of the overlap region.

### Method
Get

### Endpoint
Rhino.Geometry.Intersect.IntersectionEvent.PointB

### Parameters
This is a property and does not take parameters.

### Request Example
This is a property access, not an API call with a request body.

### Response
#### Success Response (200)
- **Point3d** (Point3d) - The intersection point on Curve B or Surface B.

#### Response Example
```json
{
  "x": 1.0,
  "y": 2.0,
  "z": 3.0
}
```
```

--------------------------------

### ViewInfo() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.viewinfo/viewinfo

Creates a default ViewInfo instance.

```APIDOC
## ViewInfo()

### Description
Creates a default ViewInfo instance.

### Method
`public ViewInfo()`

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "new ViewInfo()"
}
```

### Response
#### Success Response (N/A)
- **ViewInfo** (object) - A default ViewInfo instance.

#### Response Example
```json
{
  "example": "{ ... ViewInfo object ... }"
}
```

### Availability
Available since: 8.2
```

--------------------------------

### Extrusion MiterPlaneNormalAtStart

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.extrusion/miterplanenormalatstart

Gets or sets the normal of the miter plane at the start in profile coordinates. In profile coordinates, 0,0,1 always maps to the extrusion axis.

```APIDOC
## Extrusion MiterPlaneNormalAtStart

### Description
Gets or sets the normal of the miter plane at the start in profile coordinates. In profile coordinates, 0,0,1 always maps to the extrusion axis.

### Method
Get/Set

### Endpoint
Rhino.Geometry.Extrusion.MiterPlaneNormalAtStart

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "Not applicable for property"
}
```

### Response
#### Success Response (200)
- **Vector3d** - The normal of the miter plane at the start.

#### Response Example
```json
{
  "example": "[0.0, 0.0, 1.0]"
}
```

### Remarks
Available since Rhino version 5.0.
```

--------------------------------

### Cylinder.ToBrep Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.cylinder/tobrep

Constructs a Brep representation of this Cylinder. This is synonymous with calling NurbsSurface.CreateFromCylinder().

```APIDOC
## Cylinder.ToBrep

### Description
Constructs a Brep representation of this Cylinder. This is synonymous with calling NurbsSurface.CreateFromCylinder().

### Method
`public Brep ToBrep(Boolean capBottom, Boolean capTop)`

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "No request body example available."
}
```

### Response
#### Success Response (200)
- **Brep** (Brep) - A Brep representation of the cylinder or null.

#### Response Example
```json
{
  "example": "No response body example available."
}
```

### Remarks
Available since: 5.0
```

--------------------------------

### DimensionStyle.FixedExtensionLength Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.dimensionstyle/fixedextensionlength

The FixedExtensionLength property in the Rhino.DocObjects.DimensionStyle class allows you to get or set the fixed extension length for a dimension style. This property is of type double and was available starting from version 6.0.

```APIDOC
## Rhino.DocObjects.DimensionStyle.FixedExtensionLength Property

### Description
Gets or sets the fixed extension length for a dimension style.

### Method
Get/Set

### Endpoint
Rhino.DocObjects.DimensionStyle.FixedExtensionLength

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "Setting FixedExtensionLength to 5.0"
}
```

### Response
#### Success Response (200)
- **double** - The current fixed extension length value.

#### Response Example
```json
{
  "example": 5.0
}
```

### Remarks
Available since Rhino version 6.0.
```

--------------------------------

### Get Plug-in Website URL (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugininfo/website

Retrieves the website URL of the organization or company that created the plug-in. This property is read-only and returns a string. It is available starting from version 6.0.

```csharp
public string WebSite {get}
```

--------------------------------

### Get IsBeginUndo Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.commands.undoredoeventargs/isbeginundo

Retrieves a boolean value indicating if the current undo operation has started. This property is read-only and available in RhinoCommon versions 5.0 and later.

```csharp
public bool IsBeginUndo {get}
```

--------------------------------

### RenderMaterial() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendermaterial/rendermaterial

Initializes a new instance of the RenderMaterial class. This is the default constructor and typically sets up a basic render material.

```APIDOC
## RenderMaterial()

### Description
Initializes a new instance of the RenderMaterial class.

### Method
CONSTRUCTOR

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Body
None

### Request Example
```csharp
var material = new Rhino.Render.RenderMaterial();
```

### Response
#### Success Response
N/A (Constructor returns an instance)

#### Response Example
N/A (Constructor returns an instance)
```

--------------------------------

### Get ResampleTextureType (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/resampletexturetype

Retrieves the Guid value for the ResampleTextureType property. This is a static property and does not require an instance of the Rhino.Render.ContentUuids class. It is available from RhinoCommon version 6.0 onwards.

```csharp
public static Guid ResampleTextureType { get; }
```

--------------------------------

### Get Mesh Identifier (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.changequeue.meshinstance/meshid

Retrieves the unique Guid identifier for a specific mesh instance. This property is read-only and available since RhinoCommon version 6.0.

```csharp
public Guid MeshId {get}
```

--------------------------------

### Accessing ContextId Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.subdsurfaceinterpolator/contextid

Demonstrates how to get or set the ContextId property for a SubDSurfaceInterpolator object in C#. This property is a Guid and is available since Rhino 8.0.

```csharp
using Rhino.Geometry;

// Example of getting the ContextId
SubDSurfaceInterpolator interpolator = new SubDSurfaceInterpolator();
Guid contextId = interpolator.ContextId;

// Example of setting the ContextId
interpolator.ContextId = Guid.NewGuid();
```

--------------------------------

### Get Display Mode ID by Name

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Retrieves the unique identifier (GUID) for a display mode given its name. This is useful for scripting and automation where mode IDs are required.

```python
import rhinoscriptsyntax as rs
modes = rs.ViewDisplayModes(True)
for mode in modes:
    print("{} = {}".format(mode, rs.ViewDisplayModeId(mode)))
```

--------------------------------

### Rhino.Render.PreviewAppearance.Lighting()

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewappearance/lighting

Retrieves the lighting settings for a preview appearance.

```APIDOC
## Lighting method

### Description
This method retrieves the lighting settings associated with a preview appearance.

### Method
public PreviewLighting Lighting()

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response
- **ReturnValue** (PreviewLighting) - An object representing the lighting settings.

#### Response Example
```json
{
  "ReturnValue": { ... PreviewLighting object details ... }
}
```

### Availability
- Available since: 6.0
```

--------------------------------

### Get All Objects in Rhino Document

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Retrieves identifiers for all objects within the Rhino document. Supports filtering by object type and selection state. Returns a list of GUIDs.

```python
import rhinoscriptsyntax as rs

# Get identifiers of all objects
all_objects = rs.AllObjects()

# Print each object identifier
if all_objects:
    for obj_id in all_objects:
        print("Object identifier: {}".format(obj_id))
```

--------------------------------

### CreateFromBrep

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Mesh

Constructs a mesh from a Brep object. An overload is available with meshing parameters for detailed control.

```APIDOC
## POST /api/meshes/from_brep

### Description
Constructs a mesh from a Brep object.

### Method
POST

### Endpoint
/api/meshes/from_brep

### Parameters
#### Request Body
- **brep** (Brep) - Required - The Brep object to convert to a mesh.
- **meshingParameters** (MeshingParameters) - Optional - Parameters to control the meshing process.

### Request Example
```json
{
  "brep": {
    // ... brep data ...
  },
  "meshingParameters": {
    // ... meshing parameters ...
  }
}
```

### Response
#### Success Response (200)
- **mesh** (Mesh) - The resulting mesh.

#### Response Example
```json
{
  "mesh": {
    // ... mesh data ...
  }
}
```
```

--------------------------------

### Get License Status (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.licenseutils/getonelicensestatus

Retrieves the current license status for a given product ID. This is useful for UI elements that need to display license availability. The method requires a Guid representing the product.

```csharp
public static LicenseStatus GetOneLicenseStatus(Guid productId)
{
    // Implementation details to retrieve license status
    return LicenseStatus.Available; // Example return value
}
```

--------------------------------

### Get OwnerId of GripObject (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.gripobject/ownerid

Retrieves the unique identifier (Guid) of the owner of a GripObject within a Rhino document. This property is read-only and available since Rhino version 5.0.

```csharp
public Guid OwnerId {get}
```

--------------------------------

### Surface Class Overview

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Surface

Provides an overview of the Surface class, its inheritance, derived classes, namespace, and common usage.

```APIDOC
## Surface Class

Represents a base class that is common to most RhinoCommon surface types. A surface represents an entity that can be all visited by providing two independent parameters, usually called (u, v), or sometimes (s, t).

### Inheritance
- `Rhino.Runtime.CommonObject`
- `Rhino.Geometry.GeometryBase`
- `Surface`

### Derived Classes
- `Extrusion`
- `NurbsSurface`
- `PlaneSurface`
- `RevSurface`
- `SumSurface`
- `SurfaceProxy`

### Namespace
`Rhino.Geometry`
```

--------------------------------

### ProjectToBrep (IEnumerable<Curve>, IEnumerable<Brep>, Vector3d, Double, out Int32[], out Int32[])

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.curve/projecttobrep

Projects a collection of Curves onto a collection of Breps along a given direction, returning projected curves and indices.

```APIDOC
## POST /api/curves/projectToBrep/multipleCurvesMultipleBreps

### Description
Projects a collection of Curves onto a collection of Breps along a given direction.

### Method
POST

### Endpoint
/api/curves/projectToBrep/multipleCurvesMultipleBreps

### Parameters
#### Request Body
- **curves** (IEnumerable<Curve>) - Required - The curves to project.
- **breps** (IEnumerable<Brep>) - Required - The Breps to project onto.
- **direction** (Vector3d) - Required - The direction of projection.
- **tolerance** (Double) - Required - The tolerance to use for projection.

### Request Example
```json
{
  "curves": [{"type": "Curve"}],
  "breps": [{"type": "Brep"}],
  "direction": {"x": 1.0, "y": 0.0, "z": 0.0},
  "tolerance": 0.01
}
```

### Response
#### Success Response (200)
- **projectedCurves** (Curve[]) - An array of projected curves.
- **curveIndices** (Int32[]) - Index of which curve in the input list was the source for a curve in the return array.
- **brepIndices** (Int32[]) - Index of which brep was used to generate a curve in the return array.

#### Response Example
```json
{
  "projectedCurves": [
    {"type": "Curve"}
  ],
  "curveIndices": [0],
  "brepIndices": [0]
}
```
```

--------------------------------

### Get GhostedId Property Value (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaymodedescription/ghostedid

Retrieves the Guid for the ghosted display mode using the GhostedId property. This property is static and read-only. It requires access to the Rhino.Display namespace.

```csharp
using System;
using Rhino.Display;

// Assuming you have an instance of DisplayModeDescription or are accessing it statically
Guid ghostedModeId = DisplayModeDescription.GhostedId;
Console.WriteLine($"Ghosted Mode ID: {ghostedModeId}");
```

--------------------------------

### ColorHSV Constructor (ARGB)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.colorhsv/colorhsv

Constructs a new instance of ColorHSV that is equivalent to an ARGB color.

```APIDOC
## ColorHSV(Color rgb)

### Description
Constructs a new instance of ColorHSV that is equivalent to an ARGB color.

### Method
Constructor

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **ColorHSV** (ColorHSV) - A new instance of ColorHSV.

#### Response Example
None

### Remarks
Exact conversions between color spaces are often not possible.
Available since: 6.0
```

--------------------------------

### Get or Set Local String Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.localizestringpair/local

The Local property is a string that can be retrieved or set. It is available starting from version 5.0 of the RhinoCommon API. This property is part of the Rhino.UI.LocalizeStringPair class.

```csharp
public string Local {get|set}
```

--------------------------------

### Project Points to Breps using RhinoCommon API

Source: https://developer.rhino3d.com/api/rhinocommon/examples/projectpointstobreps

Demonstrates how to project a list of points onto a selected Brep using the RhinoCommon API. It takes a Brep and a list of points as input, projects them along a specified vector, and adds the projected points back to the document. Requires the RhinoCommon library.

```csharp
using Rhino;
using Rhino.DocObjects;
using Rhino.Input.Custom;
using Rhino.Commands;
using System.Collections.Generic;
using Rhino.Geometry;
using Rhino.Geometry.Intersect;

namespace examples_cs
{
  public class ProjectPointsToBrepsCommand : Command
  {
    public override string EnglishName { get { return "csProjectPtointsToBreps"; } }

    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
      var gs = new GetObject();
      gs.SetCommandPrompt("select surface");
      gs.GeometryFilter = ObjectType.Surface | ObjectType.PolysrfFilter;
      gs.DisablePreSelect();
      gs.SubObjectSelect = false;
      gs.Get();
      if (gs.CommandResult() != Result.Success)
        return gs.CommandResult();
      var brep = gs.Object(0).Brep();
      if (brep == null)
        return Result.Failure;

      var points = Intersection.ProjectPointsToBreps(
                   new List<Brep> {brep}, // brep on which to project
                   new List<Point3d> {new Point3d(0, 0, 0), new Point3d(3,0,3), new Point3d(-2,0,-2)}, // some random points to project
                   new Vector3d(0, 1, 0), // project on Y axis
                   doc.ModelAbsoluteTolerance);

      if (points != null && points.Length > 0)
      {
        foreach (var point in points)
        {
          doc.Objects.AddPoint(point);
        }
      }
      doc.Views.Redraw();
      return Result.Success;
    }
  }
}
```

--------------------------------

### BrepEdge Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_BrepEdge

Details on the constructors available for the BrepEdge class, used for object instantiation.

```APIDOC
## BrepEdge Constructors

### Description
These constructors are used internally or by inheriting classes to create instances of BrepEdge.

### Constructors

- **CommonObject()**
  Allows construction from inheriting classes.

- **CommonObject(SerializationInfo info, StreamingContext context)**
  Protected constructor for internal use.

- **Curve(SerializationInfo info, StreamingContext context)**
  Protected serialization constructor for internal use.

- **CurveProxy()**
  Protected constructor for internal use.

- **GeometryBase(SerializationInfo info, StreamingContext context)**
  Protected constructor for internal use.

```

--------------------------------

### Get DisplayName Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendercontent/displayname

Retrieves the display name of a RenderContent object. This property is read-only and returns a string. It is available starting from version 7.8 of the RhinoCommon API.

```csharp
public String DisplayName {get}
```

--------------------------------

### GetChannel Method (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectjobchannels/getchannel

Retrieves a PostEffectChannel object from the PostEffectJobChannels collection using its unique Guid identifier. This method is part of the RhinoCommon API and is available starting from version 7.0.

```csharp
public PostEffectChannel GetChannel(Guid channelId)
```

--------------------------------

### SimpleArray2dex Class

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_InteropWrappers_SimpleArray2dex

Documentation for the SimpleArray2dex class, including its constructors, properties, and methods.

```APIDOC
## SimpleArray2dex Class

Wrapper for ON_SimpleArray. If you are not writing C++ code then this class is not for you.

### Namespace
Rhino.Runtime.InteropWrappers

### Constructors

**SimpleArray2dex**()
Initializes a new `SimpleArray2dex` class.

* * *

**SimpleArray2dex**(IEnumerable<IndexPair> values)
Initializes a new `SimpleArray2dex` class with the specified values.

### Properties

**Count**
Gets the amount of elements in this array.

### Methods

**ConstPointer**()
Gets the constant (immutable) pointer of this array.

* * *

**Dispose**()
Actively reclaims unmanaged resources that this instance uses.

* * *

**NonConstPointer**()
Gets the non-constant pointer (for modification) of this array.

* * *

**ToArray**()
Returns the managed counterpart of the unmanaged array.
```

--------------------------------

### Get Median Line of Triangle3d (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.triangle3d/medianc

Retrieves the median line of a Triangle3d object that starts at corner C. This property is part of the Rhino.Geometry namespace and requires the RhinoCommon API.

```csharp
public Line MedianC { get; }
```

--------------------------------

### ViewCaptureWriter Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.viewcapturewriter/viewcapturewriter

Initializes a new instance of the ViewCaptureWriter class with specified DPI and page size.

```APIDOC
## ViewCaptureWriter constructor

### Description
Initializes a new instance of the `ViewCaptureWriter` class.

### Syntax
```csharp
public ViewCaptureWriter(
    double dpi,
    Size pageSize
)
```

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// Example usage (conceptual):
// var writer = new ViewCaptureWriter(96.0, new System.Drawing.Size(800, 600));
```

### Response
#### Success Response (200)
N/A (This is a constructor)

#### Response Example
N/A

### Available since
6.0
```

--------------------------------

### Get AltitudeC Line - RhinoCommon

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.triangle3d/altitudec

Retrieves the altitude line starting from corner C of a Triangle3d object. This property is part of the Rhino.Geometry namespace and is available since version 7.1.

```csharp
public Line AltitudeC { get; }
```

--------------------------------

### RhinoMath Constructors and Methods

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_RhinoMath

Details on the constructors and methods available in the RhinoMath class.

```APIDOC
## RhinoMath Class

Provides constants and static methods that are additional to **System.Math** .

### Constructors

#### RhinoMath()

Initializes a new instance of the RhinoMath class.

### Methods

#### Clamp(Double value, Double bound1, Double bound2)

Limits a <b>double</b> to be specified within an interval of two numbers, by specifying a fixed minimum and maximum.

#### Clamp(Int32 value, Int32 bound1, Int32 bound2)

Restricts a <b>int</b> to be specified within an interval of two integers.

#### CRC32(UInt32 currentRemainder, Byte[] buffer)

Advances the cyclic redundancy check value remainder given a byte array. http://en.wikipedia.org/wiki/Cyclic_redundancy_check.

#### CRC32(UInt32 currentRemainder, Double value)

Advances the cyclic redundancy check value remainder given a <b>double</b> . http://en.wikipedia.org/wiki/Cyclic_redundancy_check.

#### CRC32(UInt32 currentRemainder, Int32 value)

Advances the cyclic redundancy check value remainder given a <b>int</b> . http://en.wikipedia.org/wiki/Cyclic_redundancy_check.

#### EpsilonEquals(Double x, Double y, Double epsilon)

Compare two doubles for equality within some "epsilon" range.

#### EpsilonEquals(Single x, Single y, Single epsilon)

Compare to floats for equality within some "epsilon" range.

#### EvaluateNormal(Int32 limitDirection, Vector3d ds, Vector3d dt, Vector3d dss, Vector3d dst, Vector3d dtt, Vector3d n)

Expert tool to evaluate surface unit normal.

#### EvaluateNormalPartials(Vector3d ds, Vector3d dt, Vector3d dss, Vector3d dst, Vector3d dtt, Vector3d ns, Vector3d nt)

Expert tool to evaluate partial derivatives of surface unit normal.

#### EvaluateSectionalCurvature(Vector3d ds, Vector3d dt, Vector3d dss, Vector3d dst, Vector3d dtt, Vector3d planeNormal, Vector3d k)

Expert tool to evaluate sectional curvature from surface derivatives and section plane normal.

#### IntIndexToString(Int32 index)

Portrays an <b>int</b> index in text.

#### IsValidDouble(Double x)

Determines whether a <b>double</b> value is valid within the RhinoCommon context. Rhino does not use Double.NaN by convention, so this test evaluates to True if: x is not equal to RhinoMath.UnsetValue, System.Double.IsNaN(x) evaluates to false, System.Double.IsInfinity(x) evaluates to false.

#### IsValidSingle(Single x)

Determines whether a <b>float</b> value is valid within the RhinoCommon context. Rhino does not use Single.NaN by convention, so this test evaluates to True if: x is not equal to RhinoMath.UnsetValue, System.Single.IsNaN(x) evaluates to false, System.Single.IsInfinity(x) evaluates to false.

#### MetersPerUnit(UnitSystem units)

Return number of meters per one unit of a given unit system.

#### ParseNumber(String expression)

Evaluates command line math expression.

#### ToDegrees(Double radians)

Convert an angle from radians to degrees.

#### ToRadians(Double degrees)

Convert an angle from degrees to radians.

#### TryParseNumber(String expression, Double result)

Evaluates command line math expression.

#### UnitScale(UnitSystem from, Double fromMetersPerUnit, UnitSystem to, Double toMetersPerUnit)

Computes the scale factor for changing the measurements unit systems.

#### UnitScale(UnitSystem from, UnitSystem to)

Computes the scale factor for changing the measurements unit systems.

#### Wrap(Double value, Double bound1, Double bound2)

Limits a <b>double</b> to be specified within an interval of two numbers by repeating the available interval cyclically.
```

--------------------------------

### Rhino.Geometry.Brep.CreatePatch (All Controls)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createpatch

Constructs a brep patch using all available control parameters for advanced fitting.

```APIDOC
## Rhino.Geometry.Brep.CreatePatch (All Controls Overload)

### Description
Constructs a brep patch using all controls, allowing for detailed manipulation of the surface fitting process.

### Method
`public static Brep CreatePatch(
    IEnumerable<GeometryBase> geometry,
    Surface startingSurface,
    Int32 uSpans,
    Int32 vSpans,
    Boolean trim,
    Boolean tangency,
    Double pointSpacing,
    Double flexibility,
    Double surfacePull,
    Boolean[] fixEdges,
    Double tolerance
)`

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **geometry** (IEnumerable<GeometryBase>) - Required - A combination of Curve, brep trims, Point, PointCloud or Mesh. Curves and trims are sampled to get points. Trims are sampled for points and normals.
- **startingSurface** (Surface) - Optional - A starting surface (can be null).
- **uSpans** (System.Int32) - Required - Number of surface spans used when a plane is fit through points to start in the U direction.
- **vSpans** (System.Int32) - Required - Number of surface spans used when a plane is fit through points to start in the U direction.
- **trim** (System.Boolean) - Required - If true, try to find an outer loop from among the input curves and trim the result to that loop.
- **tangency** (System.Boolean) - Required - If true, try to find brep trims in the outer loop of curves and try to fit to the normal direction of the trim's surface at those locations.
- **pointSpacing** (System.Double) - Required - Basic distance between points sampled from input curves.
- **flexibility** (System.Double) - Required - Determines the behavior of the surface in areas where its not otherwise controlled by the input. Lower numbers make the surface behave more like a stiff material; higher, less like a stiff material.
- **surfacePull** (System.Double) - Required - Tends to keep the result surface where it was before the fit in areas where there is no influence from the input geometry.
- **fixEdges** (System.Boolean[]) - Required - Array of four elements. Flags to keep the edges of a starting (untrimmed) surface in place while fitting the interior of the surface. Order of flags is left, bottom, right, top.
- **tolerance** (System.Double) - Required - Tolerance used by input analysis functions for loop finding, trimming, etc.

### Request Example
```json
{
  "geometry": [],
  "startingSurface": null,
  "uSpans": 10,
  "vSpans": 10,
  "trim": true,
  "tangency": false,
  "pointSpacing": 0.1,
  "flexibility": 1.0,
  "surfacePull": 0.5,
  "fixEdges": [true, true, true, true],
  "tolerance": 0.01
}
```

### Response
#### Success Response (200)
- **Brep** (Brep) - A brep fit through input on success, or null on error.

#### Response Example
```json
{
  "brep": "[Brep Object Representation]"
}
```

### Available since
5.0
```

--------------------------------

### Get/Set MeshingParameters Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filerawwriteoptions/meshingparameters

This property allows getting or setting the MeshingParameters for file raw write options. It is of type MeshingParameters and is available starting from version 8.0.

```csharp
public MeshingParameters MeshingParameters {get|set}
```

--------------------------------

### ShowMeshWires Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.zbuffercapture/showmeshwires

Controls the display of mesh wires.

```APIDOC
## ShowMeshWires Method

### Description
Controls whether mesh wires are displayed.

### Method
```
public Void ShowMeshWires(Boolean on)
```

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "method": "ShowMeshWires",
  "parameters": {
    "on": true
  }
}
```

### Response
#### Success Response (200)
Void (no return value)

#### Response Example
N/A
```

--------------------------------

### FileIgsWriteOptions.IgesStringType Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.fileigswriteoptions/igesstringtype

The IgesStringType property within the FileIgsWriteOptions class allows you to get or set the string type mode when writing IGES files. This property is available starting from Rhino version 8.0.

```APIDOC
## FileIgsWriteOptions.IgesStringType Property

### Description
This property controls the string type mode for IGES file writing operations.

### Method
`public IgesStringTypeMode IgesStringType {get|set}`

### Endpoint
Rhino.FileIO/FileIgsWriteOptions/IgesStringType

### Parameters
This property does not have explicit path, query, or request body parameters as it is accessed directly on an instance of `FileIgsWriteOptions`.

### Request Example
```json
{
  "example": "// Accessing the property on an instance of FileIgsWriteOptions\nvar writeOptions = new FileIgsWriteOptions();\nvar currentMode = writeOptions.IgesStringType;\nwriteOptions.IgesStringType = IgesStringTypeMode.Ascii; // Example of setting the mode"
}
```

### Response
#### Success Response (200)
- **IgesStringTypeMode** (Type) - The current string type mode for IGES writing.

#### Response Example
```json
{
  "example": "// Example return value (conceptual)\nIgesStringTypeMode.Ascii"
}
```

### Remarks
- Available since Rhino version 8.0.
```

--------------------------------

### SimpleArrayDouble Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_InteropWrappers_SimpleArrayDouble

Provides documentation for the constructors of the SimpleArrayDouble class.

```APIDOC
## SimpleArrayDouble Constructors

### SimpleArrayDouble()

Initializes a new <b>SimpleArrayDouble</b> instance.

### SimpleArrayDouble(IEnumerable<double> items)

Initializes a new <b>SimpleArrayDouble</b> instance, with items.
```

--------------------------------

### RhinoHelp.Show Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.rhinohelp/show

Displays standard Rhino help content to the user. It takes a help link string as a parameter and opens the relevant documentation page.

```APIDOC
## Rhino.UI.RhinoHelp.Show Method

### Description
This method displays standard Rhino help content to the user. It requires a specific format for the help link.

### Method
```
public static Boolean Show(String helpLink)
```

### Endpoint
N/A (This is a static method within the RhinoCommon library)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "helpLink": "#commands/line.htm"
}
```

### Response
#### Success Response (Boolean)
- **ReturnValue** (Boolean) - True if the help content was displayed successfully, false otherwise.

#### Response Example
```json
{
  "ReturnValue": true
}
```

### Remarks
- The `helpLink` parameter should be a relative path to the help content, starting with '#'. For example, `#commands/line.htm`.
- Rhino will automatically append the base URL and `index.html` to the provided `helpLink`.
- This method is available since Rhino version 6.0.
```

--------------------------------

### Get Texture by Type - C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.physicallybasedmaterial/gettexture

Retrieves the texture associated with the specified texture type for a material. This method returns a Texture object. It is available starting from version 7.0.

```csharp
public Texture GetTexture(TextureType which)
```

--------------------------------

### OpenPanel (Guid, Guid)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panels/openpanel

Opens or moves a specified panel to a dock bar. This version is available on Mac Rhino by calling the version that takes a class type ID, and on Windows Rhino, it looks for a dock bar with the specified ID and opens or moves the specified panel to that dock bar.

```APIDOC
## OpenPanel (Guid dockBarId, Guid panelId)

### Description
Opens or moves a specified panel to a dock bar. This version is available on Mac Rhino by calling the version that takes a class type ID, and on Windows Rhino, it looks for a dock bar with the specified ID and opens or moves the specified panel to that dock bar.

### Method
`public static Guid OpenPanel(Guid dockBarId, Guid panelId)`

### Endpoint
N/A (This is a method call within the RhinoCommon API)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// Example usage:
System.Guid dockBarId = new System.Guid("...");
System.Guid panelId = new System.Guid("...");
System.Guid result = Rhino.UI.Panels.OpenPanel(dockBarId, panelId);
```

### Response
#### Success Response (200)
- **Guid** - Returns the Guid of the opened panel if successful.

#### Response Example
```json
{
  "returnValue": "a-guid-string"
}
```

### Availability
Available since: 5.12
```

--------------------------------

### DynamicDisplayUsage Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaypipelineattributes/dynamicdisplayusage

This property allows you to get or set the dynamic display usage for objects, affecting their appearance in the display pipeline. It is available starting from version 8.11.

```APIDOC
## DynamicDisplayUsage Property

### Description
Sets the appearance of objects in the display.

### Method
get | set

### Endpoint
Rhino.Display.DisplayPipelineAttributes.DynamicDisplayUsage

### Parameters

#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "// To get the current value:\nDynamicDisplayUse currentUsage = attributes.DynamicDisplayUsage;\n// To set a new value:\nattributes.DynamicDisplayUsage = DynamicDisplayUse.UseWhenVisible;"
}
```

### Response
#### Success Response (200)
- **DynamicDisplayUse** (enum) - The current setting for dynamic display usage.

#### Response Example
```json
{
  "example": "DynamicDisplayUse.UseWhenVisible"
}
```

### Remarks
Available since: 8.11
```

--------------------------------

### ProjectToBrep (IEnumerable<Curve>, IEnumerable<Brep>, Vector3d, Double)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.curve/projecttobrep

Projects a collection of Curves onto a collection of Breps along a given direction.

```APIDOC
## POST /api/curves/projectToBrep/multipleCurvesMultipleBrepsSimple

### Description
Projects a collection of Curves onto a collection of Breps along a given direction.

### Method
POST

### Endpoint
/api/curves/projectToBrep/multipleCurvesMultipleBrepsSimple

### Parameters
#### Request Body
- **curves** (IEnumerable<Curve>) - Required - The curves to project.
- **breps** (IEnumerable<Brep>) - Required - The Breps to project onto.
- **direction** (Vector3d) - Required - The direction of projection.
- **tolerance** (Double) - Required - The tolerance to use for projection.

### Request Example
```json
{
  "curves": [{"type": "Curve"}],
  "breps": [{"type": "Brep"}],
  "direction": {"x": 1.0, "y": 0.0, "z": 0.0},
  "tolerance": 0.01
}
```

### Response
#### Success Response (200)
- **projectedCurves** (Curve[]) - An array of projected curves or an empty array if the projection set is empty.

#### Response Example
```json
{
  "projectedCurves": [
    {"type": "Curve"}
  ]
}
```
```

--------------------------------

### Create Basic Render Environment (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderenvironment/newbasicenvironment

Constructs a new basic RenderEnvironment from a given SimulatedEnvironment. This is a simpler overload.

```csharp
public static RenderEnvironment NewBasicEnvironment(
  SimulatedEnvironment environment
)
```

--------------------------------

### Get Window Image Handle (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.namedparameterseventargs/trygetwindowimagehandle

The TryGetWindowImageHandle method attempts to retrieve the window image handle for a given window name. It returns a boolean indicating success and outputs the handle via an IntPtr. This method is available starting from RhinoCommon version 7.0. It is primarily used on Windows to get an HWND.

```csharp
public Boolean TryGetWindowImageHandle(
  String name, 
  out IntPtr value
)
```

--------------------------------

### File3dmLayerTable Methods

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_FileIO_File3dmLayerTable

Methods available for interacting with the File3dmLayerTable.

```APIDOC
## File3dmLayerTable Methods

### Description
Methods for manipulating and querying the layer table.

### Methods

- **Add**(T item)
  Adds an item to the layer table.

- **AddDefaultLayer**(String name, Color color)
  Easy way to add a default layer to the model.

- **AddLayer**(String name, Color color, Guid parentId)
  Adds a new layer to the model with a specified parent.

- **AddLayer**(String name, Color color)
  Easy way to add a new layer to the model.

- **Clear**()
  Marks all items as deleted.

- **Delete**(Int32 index)
  Flags a component as deleted using its index.

- **Delete**(T item)
  Deletes an item from the layer table. The item is flagged as deleted.

- **Delete**(T item)
  Flags a component as deleted.

- **Dump**()
  Prepares a text dump of the object table.

- **FindId**(Guid id)
  Uses the GUID to find a model component. Deleted objects cannot be found by ID. This function will not find grip objects.

- **FindIndex**(Int32 index)
  Retrieves a Layer object based on its index. This search type is discouraged in favor of ID-based searches.

- **FindName**(String name, Guid parentId)
  Finds a Layer given its name and parent ID.

- **FindNameHash**(NameHash nameHash)
  Finds a Layer given its name hash.

- **GetEnumerator**()
  Returns the enumerator that yields all items.
```

--------------------------------

### XformShear (Example from text)

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

An example demonstrating the application of a 2D shear transformation using rhinoscriptsyntax.

```APIDOC
## XformShear (Example)

### Description
This example demonstrates how to apply a 2D shear transformation to selected objects in Rhino using Python scripting.

### Method
Applies a shear transformation using `rs.XformShear` and `rs.TransformObjects`.

### Example
```python
import rhinoscriptsyntax as rs
import math

# Select objects to shear
objs = rs.GetObjects("Select objects to shear")

if objs:
    # Get the current view's construction plane
    cplane = rs.ViewCPlane()
    
    # Create a transformation matrix for changing basis from world XY to the current cplane
    cob = rs.XformChangeBasis(rs.WorldXYPlane(), cplane)
    
    # Create a 2D shear transformation matrix (45 degrees)
    shear2d = rs.XformIdentity() # Start with identity matrix
    shear2d[0,2] = math.tan(math.radians(45.0)) # Apply shear along X-axis in XY plane
    
    # Create the inverse transformation matrix for changing basis back from cplane to world XY
    cob_inv = rs.XformChangeBasis(cplane, rs.WorldXYPlane())
    
    # Combine transformations: shear * basis change
    temp = rs.XformMultiply(shear2d, cob)
    
    # Combine transformations: inverse basis change * (shear * basis change)
    xform = rs.XformMultiply(cob_inv, temp)
    
    # Apply the final transformation to the selected objects
    rs.TransformObjects( objs, xform, True )
```

### See Also
- `XformPlanarProjection`
- `XformRotation1`
- `XformRotation2`
- `XformRotation3`
- `XformRotation4`
- `XformScale`
- `XformShear`
- `XformTranslation`
```

--------------------------------

### Verify Rhino Plug-in Installation (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/pluginexists

Checks if a Rhino plug-in with the specified ID is installed. It also provides information on whether the plug-in is currently loaded and if it's protected from loading. Requires the RhinoCommon library.

```csharp
using System;
using Rhino.PlugIns;

// Example usage:
Guid pluginId = new Guid("YOUR_PLUGIN_GUID"); // Replace with the actual plugin GUID
bool loaded;
bool loadProtected;

bool exists = PlugIn.PlugInExists(pluginId, out loaded, out loadProtected);

if (exists)
{
    Console.WriteLine("Plug-in exists.");
    Console.WriteLine($"Loaded: {loaded}");
    Console.WriteLine($"Load Protected: {loadProtected}");
}
else
{
    Console.WriteLine("Plug-in does not exist.");
}
```

--------------------------------

### Get Viewport IDs for Clipping Plane (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.changequeue.clippingplane/viewids

Retrieves a list of GUIDs identifying the viewports that a specific clipping plane is set to clip. This is useful for understanding the scope of the clipping plane's effect within the Rhino scene. The property returns a List<Guid> and is available from RhinoCommon version 6.0.

```csharp
public List<Guid> ViewIds {get}
```

--------------------------------

### ColorHSV Constructor (Alpha, Hue, Saturation, Value)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.colorhsv/colorhsv

Constructs a new instance of ColorHSV with custom channel values, including alpha.

```APIDOC
## ColorHSV(double alpha, double hue, double saturation, double value)

### Description
Constructs a new instance of ColorHSV with custom channel values.

### Method
Constructor

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **ColorHSV** (ColorHSV) - A new instance of ColorHSV.

#### Response Example
None

### Remarks
Alpha channel value. Channel will be limited to 0~1.
Hue channel value. Hue channels rotate between 0.0 and 1.0.
Saturation channel value. Channel will be limited to 0~1.
Value (Brightness) channel value. Channel will be limited to 0~1.
Available since: 6.0
```

--------------------------------

### Create Preview Bitmap - C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.renderplugin/createpreview

This method generates a preview bitmap for materials and environments. It can be overridden to provide a custom preview image, otherwise, the internal OpenGL renderer will generate a simulation. The method is called with four different preview quality settings, with the first quality level being called on the main thread for fast rendering and the others on a separate thread for progressive refinement.

```csharp
protected virtual void CreatePreview(
  CreatePreviewEventArgs args
)
```

--------------------------------

### Get Rhino 2 ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinoapp/rhino2id

Retrieves the static Guid that uniquely identifies Rhino 2. This property is part of the Rhino.RhinoApp class and is accessible directly without instantiation.

```csharp
System.Guid rhino2ID = Rhino.RhinoApp.Rhino2Id;
// The variable rhino2ID now holds the Guid for Rhino 2.
```

--------------------------------

### Get RenderContent GroupId (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendercontent/groupid

Retrieves the unique identifier for the group to which the render content belongs. This property is read-write and returns a Guid. It is part of the Rhino.Render.RenderContent class.

```csharp
public Guid GroupId {get|set}
```

--------------------------------

### GetPlatformService

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_HostUtils

For internal use only. Loads an assembly for dependency injection via IPlatformServiceLocator.

```APIDOC
## GetPlatformService

### Description
For internal use only. Loads an assembly for dependency injection via IPlatformServiceLocator.

### Method
N/A (Function signature)

### Endpoint
N/A

### Parameters
* **assemblyPath** (String) - The path to the assembly.
* **typeFullName** (String) - The full name of the type to load.

### Request Example
None

### Response
* **serviceInstance** (Object) - An instance of the platform service.
```

--------------------------------

### Get NonObjectIds Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.customrendermeshes.rendermeshprovider/nonobjectids

The NonObjectIds property is part of the RenderMeshProvider class and is used to retrieve a list of GUIDs for custom render primitives. This is an optional feature for providers.

```csharp
public virtual List<Guid> NonObjectIds {get}
```

--------------------------------

### Get Content Type ID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.createprevieweventargs/contenttypeid

The ContentTypeId property returns the unique identifier (Guid) of the content for which a preview is being generated. This property is read-only and has been available since Rhino version 6.0.

```csharp
public Guid ContentTypeId {get}
```

--------------------------------

### Create Brep from Loft with Rebuild and Angle Tolerance (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfromloftrebuild

Constructs one or more Breps by lofting through a set of curves, similar to the other overload but includes an angle tolerance parameter for the loft operation. Curves are rebuilt to a specified number of control points.

```csharp
public static Brep[] CreateFromLoftRebuild(
  IEnumerable<Curve> curves,
  Point3d start,
  Point3d end,
  LoftType loftType,
  Boolean closed,
  Double angleTol,
  Int32 rebuildPointCount
)
```

--------------------------------

### Get Auto Install Plug-in Folder Path (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/autoinstallpluginfolder

Retrieves the full path to the auto-install plug-in directory. This method can target either the current machine or the current user based on the 'currentUser' boolean parameter. It is available since Rhino version 6.0.

```csharp
public static String AutoInstallPlugInFolder(  
Boolean currentUser  
)
```

--------------------------------

### Get GridTextureType Property (RhinoCommon C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/gridtexturetype

Retrieves the Guid representing the type of a grid texture. This property is static and read-only. It is available since Rhino version 6.0.

```csharp
public static Guid GridTextureType {get}
```

--------------------------------

### ShowColorDialog (Parent, Color4f, AllowAlpha, ColorCallback)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.dialogs/showcolordialog

Displays the standard modal color picker dialog for floating point colors, with options for parent window, alpha channel, and a color change callback.

```APIDOC
## POST /api/color/showdialog/callback

### Description
Displays the standard modal color picker dialog for floating point colors. Includes options for parent window, alpha channel control, and a callback for color changes.

### Method
POST

### Endpoint
/api/color/showdialog/callback

### Parameters
#### Request Body
- **parent** (Object) - Optional - Parent window for this dialog. Should always pass this if calling from a form or user control.
- **color** (Color4f) - Required - The initial color to set the picker to and also accepts the user's choice.
- **allowAlpha** (Boolean) - Required - Specifies if the color picker should allow changes to the alpha channel or not.
- **colorCallback** (String) - Optional - An identifier or endpoint for a callback function to be invoked when the color value changes in the color dialog.

### Request Example
```json
{
  "parent": "main_window_handle",
  "color": {
    "r": 0.9,
    "g": 0.8,
    "b": 0.7,
    "a": 0.6
  },
  "allowAlpha": false,
  "colorCallback": "/api/callbacks/color_update"
}
```

### Response
#### Success Response (200)
- **success** (Boolean) - True if a color was picked, False if the user canceled the picker dialog.
- **color** (Color4f) - The selected color if successful.

#### Response Example
```json
{
  "success": true,
  "color": {
    "r": 0.2,
    "g": 0.3,
    "b": 0.4,
    "a": 0.5
  }
}
```
```

--------------------------------

### GetActivePlugInVersionFolders (currentUser Parameter)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/getactivepluginversionfolders

Recurses through the auto install plug-in folders and returns the directories containing 'active' versions of plug-ins, based on the specified user context.

```APIDOC
## GetActivePlugInVersionFolders

### Description
Recurses through the auto install plug-in folders and returns the directories containing "active" versions of plug-ins, based on the specified user context.

### Method
GET

### Endpoint
/Rhino.Runtime/HostUtils/GetActivePlugInVersionFolders

### Parameters
#### Query Parameters
- **currentUser** (boolean) - Required - If true, checks the current user's plug-in folders; if false, checks the machine's plug-in folders.

#### Request Body
None

### Request Example
```json
{
  "currentUser": true
}
```

### Response
#### Success Response (200)
- **directories** (DirectoryInfo[]>)
  - A list of directory information for active plug-in versions.

#### Response Example
```json
{
  "directories": [
    {
      "fullName": "C:\\Users\\CurrentUser\\AppData\\Roaming\\Rhino\\Plug-ins\\AnotherPlugin",
      "name": "AnotherPlugin",
      "exists": true
    }
  ]
}
```
```

--------------------------------

### Get Display Mode Name by ID

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Retrieves the name of a display mode given its unique identifier (GUID). This function is the inverse of ViewDisplayModeId and is useful for displaying mode names.

```python
import rhinoscriptsyntax as rs
modes = rs.ViewDisplayModes(False)
for mode in modes:
    print("{} = {}".format(mode, rs.ViewDisplayModeName(mode)))
```

--------------------------------

### RhinoPageInterop Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.rhinopageinterop/rhinopageinterop

Initializes a new instance of the RhinoPageInterop class.

```APIDOC
## RhinoPageInterop()

### Description
Initializes a new instance of the RhinoPageInterop class.

### Method
Constructor

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "RhinoPageInterop()"
}
```

### Response
#### Success Response (Initialization)
- Initializes an object of type RhinoPageInterop.

#### Response Example
```json
{
  "example": "Instance of RhinoPageInterop created."
}
```
```

--------------------------------

### RhinoCore(string[] args) Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.inprocess.rhinocore/rhinocore

Initializes a new instance of the RhinoCore class with specified command-line arguments.

```APIDOC
## RhinoCore(string[] args)

### Description
Initializes a new instance of the RhinoCore class with the provided command-line arguments.

### Method
`public RhinoCore(string[] args)`

### Endpoint
N/A (Constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Parameters
*   **args** (System.String[]) - Rhino command line parameters. For documentation, see "https://developer.rhino3d.com/guides/cpp/running-rhino-from-command-line/"

### Request Example
```csharp
string[] rhinoArgs = {" /silent "};

var rhinoCore = new RhinoCore(rhinoArgs);
```

### Response
#### Success Response
Initializes the RhinoCore instance with the provided command-line arguments.

#### Response Example
N/A (Constructor)
```

--------------------------------

### Get Viewport ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.viewportinfo/id

Retrieves the unique identifier (Guid) of a Rhino viewport using the Id property of the ViewportInfo class. This property is read-only after initialization.

```csharp
using Rhino.DocObjects;

// Assuming 'viewportInfo' is an instance of ViewportInfo
Guid viewportId = viewportInfo.Id;
System.Console.WriteLine("Viewport ID: " + viewportId);

```

--------------------------------

### RecordInitInstanceTime Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/recordinitinstancetime

Records the time taken during instance initialization, useful for performance analysis with the -stopwatch flag.

```APIDOC
## RecordInitInstanceTime

### Description
Used to help record times at startup with the -stopwatch flag to help determine bottlenecks in start up speed.

### Method
public static Void RecordInitInstanceTime

### Endpoint
Rhino.Runtime.HostUtils/RecordInitInstanceTime

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **description** (String) - Required - A description of the event to record.

### Request Example
```json
{
  "description": "Example startup event"
}
```

### Response
#### Success Response (200)
Type: Void

#### Response Example
None (void return type)
```

--------------------------------

### Get Texture Identifier (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.texture/id

Retrieves the globally unique identifier (Guid) for a given texture object in Rhino. This property is read-only and available since Rhino version 5.0.

```csharp
public Guid Id {get}
```

--------------------------------

### MeshPart.StartVertexIndex

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.meshpart/startvertexindex

This section details the StartVertexIndex property of the Rhino.Geometry.MeshPart class, which indicates the starting vertex index for a given mesh part.

```APIDOC
## MeshPart.StartVertexIndex

### Description
This property returns the starting vertex index of a subinterval of the parent mesh's vertex array.

### Method
Get

### Endpoint
Rhino.Geometry.MeshPart.StartVertexIndex

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "No request body needed for property access"
}
```

### Response
#### Success Response (200)
- **startVertexIndex** (int) - The integer index representing the start of the vertex subinterval.

Available since: 5.6

#### Response Example
```json
{
  "startVertexIndex": 0
}
```
```

--------------------------------

### Get Plug-in IDs (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.materialrefs/keys

Retrieves an ICollection of plug-in GUIDs stored within the MaterialRefs dictionary. This property is read-only and available since RhinoCommon version 5.10.

```csharp
public ICollection<Guid> Keys {get}
```

--------------------------------

### PreviewLighting Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewlighting/previewlighting

Constructs a new instance of the PreviewLighting class.

```APIDOC
## PreviewLighting constructor

### Description
Constructor for PreviewLighting.

### Method
public

### Endpoint
Rhino.Render.PreviewLighting.PreviewLighting

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "No request body"
}
```

### Response
#### Success Response (200)
- **pPreviewLighting** (IntPtr) - The pointer to the PreviewLighting object.

#### Response Example
```json
{
  "example": "PreviewLighting object created"
}
```

### Remarks
Available since: 6.0
```

--------------------------------

### Get Camera Path ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.animationproperties/camerapathid

Retrieves the unique identifier (Guid) for the camera path from the AnimationProperties object. This property is available since RhinoCommon version 6.11.

```csharp
using Rhino.DocObjects;

// Assuming 'animationProperties' is an instance of AnimationProperties
Guid cameraPathId = animationProperties.CameraPathId;

```

--------------------------------

### FileSat Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filesat/filesat

Initializes a new instance of the FileSat class. This class is part of the Rhino.FileIO namespace and is used for handling SAT file formats.

```APIDOC
## FileSat()

### Description
Initializes a new instance of the FileSat class.

### Method
CONSTRUCTOR

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```csharp
Rhino.FileIO.FileSat myFileSat = new Rhino.FileIO.FileSat();
```

### Response
#### Success Response (Initialization)
- **FileSat** (Object) - An initialized instance of the FileSat class.

#### Response Example
```json
{
  "message": "FileSat object initialized successfully."
}
```
```

--------------------------------

### ShowBuyLicenseUi Method (RhinoCommon API)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.licenseutils/showbuylicenseui

Displays the Rhino license purchase UI for a specified product ID. This method is static and belongs to the LicenseUtils class. It returns void and is available since version 5.5 of the RhinoCommon API.

```csharp
public static Void ShowBuyLicenseUi(
  Guid productId
)
```

--------------------------------

### Get RhinoThicknessAnalysisModeId (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.visualanalysismode/rhinothicknessanalysismodeid

Retrieves the static Guid identifier for Rhino's built-in thickness analysis mode. This property is read-only and available from RhinoCommon version 5.0 onwards.

```csharp
public static Guid RhinoThicknessAnalysisModeId { get; }
```

--------------------------------

### Rhino.Render.Fields.StringField.Value Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.fields.stringfield/value

The Value property in the StringField class allows you to get or set the string value of a field. This property is available starting from version 5.1 of the API.

```APIDOC
## Rhino.Render.Fields.StringField.Value Property

### Description
Gets or sets the field value.

### Method
`get` | `set`

### Endpoint
N/A (This is a class property, not an API endpoint)

### Parameters
N/A

### Request Example
N/A

### Response
#### Success Response (N/A)
- **Type**: string
- **Description**: The string value of the field.

#### Response Example
N/A

### Available since
5.1
```

--------------------------------

### HostUtils Methods

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_HostUtils

This section details the methods of the HostUtils class, which are used for various runtime operations such as plugin management, debugging, and environment checks.

```APIDOC
## HostUtils Methods

### Description
Methods of the HostUtils class for managing plugins, debugging, and interacting with the Rhino runtime environment.

### Method
Various (GET, POST, etc. depending on the specific method's operation, though most are static utility calls).

### Endpoint
N/A (Class methods)

### Methods
#### AutoInstallPlugInFolder
- **AutoInstallPlugInFolder(Boolean currentUser)**
  Gets the auto-install plug-in folder for the machine or the current user.

#### CallFromCoreRhino
- **CallFromCoreRhino(String task)**
  A critical method called by Rhino on initial startup. Do not change its signature without consulting Steve.

#### CheckForRdk
- **CheckForRdk(Boolean throwOnFalse, Boolean usePreviousResult)**
  Determines if the RDK (Rhino Device Kit) is loaded.

#### ClearFpuExceptionStatus
- **ClearFpuExceptionStatus()**
  Clears the FPU (Floating-Point Unit) exception and busy flags.

#### CreateCommands
- **CreateCommands(PlugIn plugin)**
  Parses a plugin and creates all the commands defined within it.
- **CreateCommands(IntPtr pPlugIn, Assembly pluginAssembly)**
  Parses a plugin and creates all the commands defined within it, using an IntPtr and Assembly.

#### CreatePlugIn
- **CreatePlugIn(Type pluginType, Boolean printDebugMessages)**
  Instantiates a plug-in type and registers its associated commands and classes.

#### DebugDumpToString
- **DebugDumpToString(BezierCurve bezierCurve)**
  Gets a text description of the geometric contents of a Bezier curve for debugging purposes.
- **DebugDumpToString(GeometryBase geometry)**
  Gets a text description of the geometric contents of a GeometryBase object for debugging purposes.

#### DebugString
- **DebugString(String format, Object[] args)**
  Prints a formatted debug message to the Rhino Command Line, only if `SendDebugToCommandLine` is true.
- **DebugString(String msg)**
  Prints a debug message string to the Rhino Command Line, only if `SendDebugToCommandLine` is true.

### Request Body
(Not applicable for most static utility methods, but may apply to methods involving complex object manipulation if they were exposed as endpoints.)

### Response
#### Success Response (200)
- **Various** - The return type depends on the specific method called (e.g., string, boolean, void, or specific object types).

### Response Example
(Examples would be specific to each method's return type and operation.)
```json
// Example for DebugString if it returned a status
{
  "status": "success"
}
```
```json
// Example for CreatePlugIn (conceptual)
{
  "pluginId": "some-plugin-guid"
}
```
```

--------------------------------

### Get ValueAsObject from FloatField (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.fields.floatfield/valueasobject

The ValueAsObject method returns the value of a FloatField as an Object. This method is available starting from RhinoCommon version 5.7. It is an override of a base class method.

```csharp
public override Object ValueAsObject()
{
  // Method implementation goes here
}
```

--------------------------------

### PhysicallyBased Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.parameternames.physicallybased/physicallybased

Initializes a new instance of the PhysicallyBased class.

```APIDOC
## PhysicallyBased Constructor

### Description
Initializes a new instance of the PhysicallyBased class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "PhysicallyBased()"
}
```

### Response
#### Success Response (200)
Represents the initialized PhysicallyBased object.

#### Response Example
```json
{
  "example": "PhysicallyBased object created"
}
```
```

--------------------------------

### GetPointDynamicDraw C# Example

Source: https://developer.rhino3d.com/api/rhinocommon/examples/getpointdynamicdraw

This C# example demonstrates how to use the GetPointDynamicDraw functionality in RhinoCommon. It creates a custom point getter that draws a circle dynamically as the user defines the radius. Dependencies include RhinoCommon namespaces for geometry and commands. It takes user input for a center point and then interactively defines the radius, finally adding a circle object to the document.

```csharp
using Rhino;
using Rhino.Geometry;
using Rhino.Commands;
using Rhino.Input.Custom;

namespace examples_cs
{
  public class GetPointDynamicDrawCommand : Command
  {
    public override string EnglishName { get { return "csGetPointDynamicDraw"; } }

    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
      var gp = new GetPoint();
      gp.SetCommandPrompt("Center point");
      gp.Get();
      if (gp.CommandResult() != Result.Success)
        return gp.CommandResult();
      var center_point = gp.Point();
      if (center_point == Point3d.Unset)
        return Result.Failure;

      var gcp = new GetCircleRadiusPoint(center_point);
      gcp.SetCommandPrompt("Radius");
      gcp.ConstrainToConstructionPlane(false);
      gcp.SetBasePoint(center_point, true);
      gcp.DrawLineFromPoint(center_point, true);
      gcp.Get();
      if (gcp.CommandResult() != Result.Success)
        return gcp.CommandResult();

      var radius = center_point.DistanceTo(gcp.Point());
      var cplane = doc.Views.ActiveView.ActiveViewport.ConstructionPlane();
      doc.Objects.AddCircle(new Circle(cplane, center_point, radius));
      doc.Views.Redraw();
      return Result.Success;
    }
  }

  public class GetCircleRadiusPoint : GetPoint
  {
    private Point3d m_center_point;
 
    public GetCircleRadiusPoint(Point3d centerPoint)
    {
      m_center_point = centerPoint;
    }

    protected override void OnDynamicDraw(GetPointDrawEventArgs e)
    {
      base.OnDynamicDraw(e);
      var cplane = e.RhinoDoc.Views.ActiveView.ActiveViewport.ConstructionPlane();
      var radius = m_center_point.DistanceTo(e.CurrentPoint);
      var circle = new Circle(cplane, m_center_point, radius);
      e.Display.DrawCircle(circle, System.Drawing.Color.Black);
    }
  }
}
```

--------------------------------

### RhinoCore(string[] args, WindowStyle windowStyle) Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.inprocess.rhinocore/rhinocore

Initializes a new instance of the RhinoCore class with specified command-line arguments and window style.

```APIDOC
## RhinoCore(string[] args, WindowStyle windowStyle)

### Description
Initializes a new instance of the RhinoCore class with command-line arguments and a specified window style.

### Method
`public RhinoCore(string[] args, WindowStyle windowStyle)`

### Endpoint
N/A (Constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Parameters
*   **args** (System.String[]) - Rhino command line parameters. For documentation, see "https://developer.rhino3d.com/guides/cpp/running-rhino-from-command-line/"
*   **windowStyle** (WindowStyle) - Rhino main window initial style.

### Request Example
```csharp
string[] rhinoArgs = {" /silent "};
WindowStyle style = WindowStyle.Normal;

var rhinoCore = new RhinoCore(rhinoArgs, style);
```

### Response
#### Success Response
Initializes the RhinoCore instance with the provided arguments and window style.

#### Response Example
N/A (Constructor)
```

--------------------------------

### Decal.StartLongitude Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.decal/startlongitude

Gets the start angle of the decal's arc of longitude or 'vertical sweep'. This is a latitudinal angle only used when mapping is spherical. It is deprecated in favor of VertSweep().

```APIDOC
## Decal.StartLongitude Property

### Description
Gets the start angle of the decal's arc of longitude or 'vertical sweep'. This is a latitudinal angle only used when mapping is spherical. It is deprecated in favor of VertSweep().

### Method
GET

### Endpoint
/websites/developer_rhino3d_api/Rhino.Render/Decal/StartLongitude

### Parameters

### Request Body

### Request Example
```json
{
  "example": "null"
}
```

### Response
#### Success Response (200)
- **return_value** (double) - The start angle of the decal's arc of longitude.

#### Response Example
```json
{
  "example": 3.14159
}
```
```

--------------------------------

### StartLatitude Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.decal/startlatitude

Gets the start angle of the decal's arc of latitude or 'horizontal sweep'. This is a longitudinal angle and is only used for cylindrical or spherical mapping. This property is deprecated in favor of HorzSweep().

```APIDOC
## StartLatitude Property

### Description
Gets the start angle of the decal's arc of latitude or 'horizontal sweep'. This is a longitudinal angle and is only used for cylindrical or spherical mapping. This property is deprecated in favor of HorzSweep().

### Class
Rhino.Render.Decal

### Syntax
public double StartLatitude {get}

### Returns
Type: double

### Available since
5.10
```

--------------------------------

### Get Geometry Information (RhinoCommon API)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.datasources.metadata/geometry

The Geometry method returns a string representation of the geometry information associated with the metadata. This method is available starting from RhinoCommon version 6.0.

```csharp
public String Geometry()
```

--------------------------------

### Layer Class Documentation

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_DocObjects_Layer

Detailed documentation for the Layer class, including inheritance, constructors, and properties.

```APIDOC
## Layer Class

### Description
Represents a layer in the Rhino document. This class inherits from `Rhino.Runtime.CommonObject` and `Rhino.DocObjects.ModelComponent`.

### Inheritance
- `Rhino.Runtime.CommonObject`
- `Rhino.DocObjects.ModelComponent`

### Namespace
`Rhino.DocObjects`

### Constructors

*   **CommonObject()**
    Allows construction from inheriting classes.

*   **CommonObject(SerializationInfo info, StreamingContext context)**
    Protected constructor for internal use.

*   **Layer()**
    Default constructor for the Layer class.

### Properties

*   **Color** (Color) - Gets or sets the display color for this layer.
*   **ComponentStatus** (ComponentStatus) - Gets or sets the status of the layer.
*   **DeletedName** (string) - Gets the name of a component that is deleted.
*   **Disposed** (bool) - Indicates if this object has been disposed or the document it originally belonged to has been disposed.
*   **FullPath** (string) - Gets the full path to this layer, including nesting information.
*   **HasId** (bool) - Returns a value indicating whether the component has an ID.
*   **HasIndex** (bool) - Returns a value indicating whether the component has an Index.
*   **HasName** (bool) - Returns a value indicating whether the component has a Name.
*   **HasUserData** (bool) - Gets True if this class has any custom information attached to it through UserData.
*   **Id** (Guid) - Gets or sets the ID of this layer object. You typically do not need to assign a custom ID.
*   **IdIsLocked** (bool) - Returns a value indicating whether the component ID is already locked.
*   **IgesLevel** (int) - Gets or sets the IGES level for this layer.
*   **Index** (int) - Gets or sets the model component index attribute.
*   **IndexIsLocked** (bool) - Returns a value indicating whether the component Index is already locked.
*   **InstanceDefinitionModelSerialNumber** (int) - Identifies the linked instance definition reference model when a component is part of linked instance definition information.
*   **IsComponentStatusLocked** (bool) - Returns an indication if the component status itself can be locked.
*   **IsCurrent** (bool) - Returns True if the layer is the current layer.
*   **IsDeleted** (bool) - Gets a value indicating whether this layer has been deleted and is currently in the Undo buffer.
*   **IsDocumentControlled** (bool) - If True, this object may not be modified. Any properties or functions that attempt to modify this object when it is set to "IsReadOnly" will throw a NotSupportedException.
*   **IsExpanded** (bool) - Gets or sets a value indicating whether this layer is expanded in the Rhino Layer dialog.
*   **IsLocked** (bool) - Gets or sets a value indicating the locked state of this layer.
*   **IsReference** (bool) - Gets a value indicating whether this layer is a referenced layer. Referenced layers are part of referenced documents.
*   **IsReferenceParentLayer** (bool) - Returns True if the layer is a parent layer of the layer tree from a linked instance definition or a worksession reference model.
*   **IsSystemComponent** (bool) - True if this model component is a system constant.
*   **IsValid** (bool) - Tests an object to see if it is valid.
*   **IsVisible** (bool) - Gets or sets the global visibility of this layer.
*   **IsVisibleInUserInterface** (bool) - Returns True if the layer is visible in user interfaces that display layers. This is a runtime property and does not persist in .3dm files.
*   **LayerIndex** (int) - Gets or sets the index of this layer.
*   **LinetypeIndex** (int) - Gets or sets the line-type index for this layer.
*   **ModelIsVisible** (bool) - Gets or sets the model visibility of this layer.

```

--------------------------------

### Get RenewableUntil Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.licenselease/renewableuntil

Retrieves the expiration date of the cloud zoo license. This property returns a nullable DateTime object. It is available starting from version 7.25.

```csharp
public DateTime? RenewableUntil {get}
```

--------------------------------

### Generate Quick Render Content Preview (with LinearWorkflow)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendercontent/generatequickcontentpreview

Generates a quick render content preview with specified dimensions and scene server. This overload includes an optional LinearWorkflow parameter. It returns a Bitmap representing the preview. Available since RhinoCommon 8.16.

```csharp
public static Bitmap GenerateQuickContentPreview(
  LinearWorkflow lw,
  RenderContent c,
  Int32 width,
  Int32 height,
  PreviewSceneServer psc,
  Boolean bSuppressLocalMapping,
  Int32 reason,
  ref Result result
)
```

--------------------------------

### Get Default Parse Settings (Degrees)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.stringparsersettings/parsesettingsdegrees

Retrieves the default StringParserSettings object where angle values without specified units are interpreted as degrees. This property is available starting from Rhino version 6.0.

```csharp
public static StringParserSettings ParseSettingsDegrees {get}
```

--------------------------------

### FileDwgReadOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filedwgreadoptions/filedwgreadoptions

Initializes a new instance of the FileDwgReadOptions class used for reading DWG files.

```APIDOC
## FileDwgReadOptions()

### Description
Initializes a new instance of the FileDwgReadOptions class.

### Method

### Endpoint

### Parameters

### Request Body

### Request Example

### Response
#### Success Response (200)
An initialized `FileDwgReadOptions` object.

### Response Example
```json
{
  "//": "This constructor does not return a value, it initializes an object."
}
```
```

--------------------------------

### Get Median Line B (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.triangle3d/medianb

Retrieves the median line of a Triangle3d object that starts at corner B. This property is read-only and returns a Line object. It requires the Rhino.Geometry namespace.

```csharp
public Line MedianB {get}
```

--------------------------------

### Rhino.Geometry.Transform.M13 Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.transform/m13

The M13 property within the Rhino.Geometry.Transform class allows you to get or set a double value. This property is available starting from version 5.0 of the API.

```APIDOC
## M13 Property

### Description
Gets or sets a double value representing a component of the transformation matrix.

### Method
`get` or `set`

### Endpoint
`/websites/developer_rhino3d_api/Rhino.Geometry/Transform/M13`

### Parameters
This property does not take any parameters.

### Request Example
```json
{
  "value": 1.234
}
```

### Response
#### Success Response (200)
- **value** (double) - The double value of the M13 component.

#### Response Example
```json
{
  "value": 1.234
}
```
```

--------------------------------

### Interop Class Documentation

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_Interop

Documentation for the Interop class and its methods.

```APIDOC
## Interop Class

### Description
Contains static methods to marshal objects between RhinoCommon and legacy Rhino_DotNet or C++.

### Namespace
Rhino.Runtime

### Constructors

#### Interop()
Initializes a new instance of the Interop class.

### Methods

#### CommandLineOptionFromNativePointer(IntPtr ptrCommandLineOption)
Create a command line option for a native pointer. Do not hold onto this class as it does not control the lifetime of the underlying pointer.

#### CreateFromNativePointer(IntPtr pGeometry)
Constructs a RhinoCommon Geometry class from a given ON_Geomety*. The ON_Geometry* must be declared on the heap and its lifetime becomes controlled by RhinoCommon.

#### FileReadOptionsConstPointer(FileReadOptions options)
Returns the underlying const CRhinoFileReadOptions* for a Rhino.FileIO.FileReadOptions object. You should only be interested in using this function if you are writing C++ code.

#### FileWriteOptionsConstPointer(FileWriteOptions options)
Returns the underlying const CRhinoFileWriteOptions* for a Rhino.FileIO.FileWriteOptions object. You should only be interested in using this function if you are writing C++ code.

#### FontFromPointer(IntPtr ptrManagedFont)
Create managed Font from native ON_Font*

#### FromOnBrep(Object source)
Copies a Rhino_DotNet brep to a RhinoCommon brep class.

#### FromOnCurve(Object source)
Copies a Rhino_DotNet curve to a RhinoCommon curve class.

#### FromOnMesh(Object source)
Copies a Rhino_DotNet mesh to a RhinoCommon mesh class.

#### FromOnSurface(Object source)
Copies a Rhino_DotNet surface to a RhinoCommon Surface class.

#### NativeGeometryConstPointer(GeometryBase geometry)
Returns the underlying const ON_Geometry* for a RhinoCommon class. You should only be interested in using this function if you are writing C++ code.

#### NativeGeometryNonConstPointer(GeometryBase geometry)
Returns the underlying non-const ON_Geometry* for a RhinoCommon class. You should only be interested in using this function if you are writing C++ code.

#### NativeNonConstPointer(DisplayPipeline pipeline)
Get CRhinoDisplayPipeline* for a DisplayPipeline instance

#### NativeNonConstPointer(RhinoViewport viewport)
Get CRhinoViewport* from a RhinoViewport instance

#### NativeNonConstPointer(ViewCaptureSettings settings)
Get a CRhinoPrintInfo* for a given ViewCaptureSettings class

#### NativeNonConstPointer(ViewportInfo viewport)
Get ON_Viewport* from a ViewportInfo instance

#### NativeNonConstPointer(GetPoint getPoint)
Get CRhinoGetPoint* from a GetPoint instance

#### NativeRhinoDocPointer(RhinoDoc doc)
Gets the C++ CRhinoDoc* for a given RhinoCommon RhinoDoc class.

#### NSFontFromFont(Font font, Double pointSize)
Get native NSFont* from a Rhino Font. Only works on Mac

#### NSFontFromFont(Font font)
Get native NSFont* from a Rhino Font. Only works on Mac

#### PlugInPointer(PlugIn plugin)
Gets a C++ plug-in pointer for a given RhinoCommon plug-in. This is a Rhino SDK function.

#### RhinoObjectConstPointer(RhinoObject rhinoObject)
Returns the underlying const CRhinoObject* for a RhinoCommon class. You should only be interested in using this function if you are writing C++ code.

#### RhinoObjectFromPointer(IntPtr pRhinoObject)
Constructs a RhinoCommon Rhino object from an unmanaged C++ RhinoObject pointer.

#### ToIRhinoViewport(RhinoViewport source)
Convert a Rhino.Display.Viewport to an RMA.Rhino.IRhinoViewport.

#### ToOnBrep(Brep source)
Constructs a Rhino_DotNet OnBrep that is a copy of a given brep.

#### ToOnCurve(Curve source)
Constructs a Rhino_DotNet OnCurve that is a copy of a given curve.

#### ToOnMesh(Mesh source)
Constructs a Rhino_DotNet OnMesh that is a copy of a given mesh.

#### ToOnSurface(Surface source)
Constructs a Rhino_DotNet OnSurface that is a copy of a given curve.

#### ToOnXform(Transform source)
Constructs a Rhino_DotNet OnXform from a given RhinoCommon Transform.

#### TryCopyFromOnArc(Object source, Arc destination)
Attempts to copy the contents of a RMA.OpenNURBS.OnArc to a Rhino.Geometry.Arc.

#### TryCopyToOnArc(Arc source, Object destination)
Attempts to copy the contents of a Rhino.Geometry.Arc to a RMA.OpenNURBS.OnArc.

#### ViewCaptureFromPointer(IntPtr ptrViewCapture)
Create a ViewCaptureSettings class from a native const CRhinoPrintInfo* The pointer values are copied
```

--------------------------------

### Get Plane Aligned Bounding Box

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.geometrybase/getboundingbox

Computes a bounding box aligned to a specified plane. This overload takes only the orientation plane as input. It is available starting from version 5.0.

```csharp
public BoundingBox GetBoundingBox(Plane plane)
```

--------------------------------

### RenderFull Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.animationproperties/renderfull

Gets or sets a value indicating whether to capture a frame in rendered mode. This property is of type bool and was made available starting from version 6.11.

```APIDOC
## RenderFull Property

### Description
Gets or sets a value indicating whether to capture a frame in rendered mode.

### Method
GET | SET

### Endpoint
/websites/developer_rhino3d_api/Rhino.DocObjects/AnimationProperties/RenderFull

### Parameters

#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
GET: /websites/developer_rhino3d_api/Rhino.DocObjects/AnimationProperties/RenderFull
SET: /websites/developer_rhino3d_api/Rhino.DocObjects/AnimationProperties/RenderFull?value=true

### Response
#### Success Response (200)
- **value** (bool) - The current value of the RenderFull property.

#### Response Example
{
  "value": true
}
```

--------------------------------

### AddOption (overload 6)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getbaseclass/addoption

Adds a command line option with an English name.

```APIDOC
## POST /AddOption

### Description
Adds a command line option with an English name.

### Method
POST

### Endpoint
/AddOption

### Parameters
#### Request Body
- **englishOption** (String) - Required - Must only consist of letters and numbers (no characters list periods, spaces, or dashes).

### Response
#### Success Response (200)
- **return_value** (Int32) - Option index value (>0) or 0 if option cannot be added.

Available since: 5.0
```

--------------------------------

### FileStlWriteOptions.ToDictionary Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filestlwriteoptions/todictionary

This method creates a dictionary of the current file export options. This dictionary can then be used with the RhinoDoc.Export function.

```APIDOC
## FileStlWriteOptions.ToDictionary Method

### Description
Creates a dictionary of these options. This dictionary can be passed to the RhinoDoc.Export function.

### Method
`public ArchivableDictionary ToDictionary()`

### Endpoint
N/A (Class Method)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (200)
- **Type**: `ArchivableDictionary` - A dictionary containing the file export options.

#### Response Example
```json
{
  "option1": "value1",
  "option2": "value2"
}
```
```

--------------------------------

### Fit Surface

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Extrusion

Fits a new surface through

--------------------------------

### GetModelToEarthTransform C# Example

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.earthanchorpoint/getmodeltoearthtransform

Demonstrates how to get the transformation from model coordinates to Earth coordinates using the GetModelToEarthTransform method in C#. This method is useful for geo-referencing models within Rhino.

```csharp
using Rhino.DocObjects;
using Rhino.Geometry;

// Assuming 'modelUnitSystem' is a valid UnitSystem enum value
UnitSystem modelUnitSystem = UnitSystem.Meters; // Example

Transform modelToEarthTransform = EarthAnchorPoint.GetModelToEarthTransform(modelUnitSystem);

if (!modelToEarthTransform.IsIdentity)
{
    // Use the transform to convert points from model to Earth coordinates
    // For example, if M is a point in model coordinates:
    // Point3d M = new Point3d(x, y, z);
    // Point3d E = modelToEarthTransform * M;
    // E.X will represent latitude, E.Y longitude, E.Z elevation.
    RhinoApp.WriteLine("Successfully obtained model to Earth transform.");
}
else
{
    RhinoApp.WriteLine("Failed to obtain model to Earth transform.");
}
```

--------------------------------

### RealtimeDisplayMode Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.realtimedisplaymode/realtimedisplaymode

Details about the protected constructor for the RealtimeDisplayMode class.

```APIDOC
## RealtimeDisplayMode Constructor

### Description
Provides the constructor for the RealtimeDisplayMode class.

### Method
protected

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
N/A (Constructor)

### Response
N/A (Constructor)

### Error Handling
None
```

--------------------------------

### Get Open Panel IDs (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panels/getopenpanelids

Retrieves an array of GUIDs for currently open panel tabs in Rhino. This method is useful for UI scripting and automation within Rhino.

```csharp
using System;
using Rhino.UI;

// Get the IDs of currently open panel tabs
Guid[] openPanelIds = Panels.GetOpenPanelIds();

// Check if any panels are open
if (openPanelIds.Length > 0) {
    Console.WriteLine("Open Panel IDs:");
    foreach (Guid id in openPanelIds) {
        Console.WriteLine(id);
    }
} else {
    Console.WriteLine("No panels are currently open.");
}
```

--------------------------------

### LOC Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.loc/loc

Initializes a new instance of the LOC class.

```APIDOC
## LOC constructor

### Description
Initializes a new instance of the LOC class.

### Method
CONSTRUCTOR

### Endpoint
Rhino.UI.LOC()

### Parameters
**None**

### Request Example
```json
{
  "example": "LOC()"
}
```

### Response
#### Success Response (200)
- **instance** (LOC) - A new instance of the LOC class.

#### Response Example
```json
{
  "example": "// Instance of LOC created"
}
```
```

--------------------------------

### Get Rhino ContextHelp Panel ID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.panelids/contexthelp

Retrieves the static Guid for the Rhino Context-Sensitive Help panel. This property is part of the Rhino.UI.PanelIds class and is available from Rhino version 5.0 onwards.

```csharp
System.Guid panelId = Rhino.UI.PanelIds.ContextHelp;

```

--------------------------------

### ProjectToBrep (Curve, Brep, Vector3d, Double)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.curve/projecttobrep

Projects a single Curve onto a single Brep along a given direction with a specified tolerance.

```APIDOC
## POST /api/curves/projectToBrep

### Description
Projects a Curve onto a Brep along a given direction.

### Method
POST

### Endpoint
/api/curves/projectToBrep

### Parameters
#### Request Body
- **curve** (Curve) - Required - The curve to project.
- **brep** (Brep) - Required - The Brep to project onto.
- **direction** (Vector3d) - Required - The direction of projection.
- **tolerance** (Double) - Required - The tolerance to use for projection.

### Request Example
```json
{
  "curve": {"type": "Curve"},
  "brep": {"type": "Brep"},
  "direction": {"x": 1.0, "y": 0.0, "z": 0.0},
  "tolerance": 0.01
}
```

### Response
#### Success Response (200)
- **projectedCurves** (Curve[]) - An array of projected curves or an empty array if the projection set is empty.

#### Response Example
```json
{
  "projectedCurves": [
    {"type": "Curve"}
  ]
}
```
```

--------------------------------

### DecalCreateParams.TextureInstanceId Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.decalcreateparams/textureinstanceid

The TextureInstanceId property of the DecalCreateParams class allows you to get or set the unique identifier for a texture instance associated with a decal. This property returns a Guid and is available since version 6.0 of the RhinoCommon API.

```APIDOC
## TextureInstanceId Property

### Description
Gets or sets the unique identifier for a texture instance.

### Method
Read/Write

### Endpoint
N/A (This is a property within a class)

### Parameters
#### Path Parameters
N/A

#### Query Parameters
N/A

#### Request Body
N/A

### Request Example
```csharp
// To get the TextureInstanceId
Guid textureId = decalCreateParams.TextureInstanceId;

// To set the TextureInstanceId
decalCreateParams.TextureInstanceId = new Guid("some-guid-string");
```

### Response
#### Success Response (200)
N/A (This is a property, not an endpoint response)

#### Response Example
N/A
```

--------------------------------

### Get Content Instance ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.datasources.metadata/contentinstanceid

The ContentInstanceId method returns a Guid that uniquely identifies the content instance. This method is part of the Rhino.Render.DataSources.MetaData class and requires RhinoCommon API.

```csharp
public Guid ContentInstanceId()
{
    // Implementation returns the unique identifier for the content instance.
    // Example: return new Guid("some-guid-value");
}
```

--------------------------------

### DrawingUtilities Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.drawingutilities/drawingutilities

Initializes a new instance of the DrawingUtilities class.

```APIDOC
## DrawingUtilities()

### Description
Initializes a new instance of the DrawingUtilities class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
Initializes the DrawingUtilities object.

#### Response Example
None
```

--------------------------------

### GetPlugInInfo Method (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getplugininfo

Retrieves detailed information about an installed Rhino plug-in. Requires the plug-in's unique identifier (Guid) as input. Returns a PlugInInfo object containing plug-in details or null if unsuccessful. Available since Rhino 6.0.

```csharp
public static PlugInInfo GetPlugInInfo(Guid pluginId)
```

--------------------------------

### Instantiate LightManagerSupportClient (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.lightmanagersupportclient/lightmanagersupportclient

This constructor initializes a new instance of the LightManagerSupportClient class. It requires a unique document identifier (doc_uuid) as input. This class is part of the Rhino.Render namespace and is available from RhinoCommon version 6.0 onwards.

```csharp
public LightManagerSupportClient(uint doc_uuid)
```

--------------------------------

### Get CompositeMaterialCCI Property (RhinoCommon C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.contentuuids/compositematerialcci

Retrieves the Guid value for the CompositeMaterialCCI property. This property is static and read-only, available since Rhino version 6.0. It is part of the Rhino.Render.ContentUuids class.

```csharp
public static Guid CompositeMaterialCCI {get}
```

--------------------------------

### EnableFromBothSidesOption Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getline/enablefrombothsidesoption

This method controls the visibility of the 'BothSides' option when interactively picking a start point. If 'true', the 'BothSides' option is displayed.

```APIDOC
## EnableFromBothSidesOption Method

### Description
If true, then the "BothSides" option shows up when the start point is interactively picked.

### Method
public Void EnableFromBothSidesOption( Boolean on )

### Endpoint
Rhino.Input.Custom.GetLine

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **on** (Boolean) - Required - Determines whether to enable or disable the 'BothSides' option.

### Request Example
```json
{
  "on": true
}
```

### Response
#### Success Response (200)
- **Type**: Void

#### Response Example
None (void return type)

### Remarks
Available since: 5.1
```

--------------------------------

### Rhino.PlugIns.LicenseUtils.ShowBuyLicenseUi

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.licenseutils/showbuylicenseui

Displays the user interface for purchasing a license for a given product ID.

```APIDOC
## Rhino.PlugIns.LicenseUtils.ShowBuyLicenseUi

### Description
Displays the user interface for purchasing a license for a given product ID.

### Method
`public static Void ShowBuyLicenseUi(Guid productId)`

### Endpoint
N/A (This is a static method within a .NET library, not a REST endpoint.)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// Example usage:
Guid myProductId = new Guid("your-product-id-guid"); 
Rhino.PlugIns.LicenseUtils.ShowBuyLicenseUi(myProductId);
```

### Response
#### Success Response (Void)
This method does not return a value.

#### Response Example
N/A
```

--------------------------------

### GetPointOnMesh Overloads for RhinoCommon

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.rhinoget/getpointonmesh

These methods get a point constrained to an existing mesh in the document. Different overloads are available depending on whether the MeshObject or its Guid is provided, and if the RhinoDoc is explicitly passed.

```csharp
public static Result GetPointOnMesh(MeshObject meshObject, String prompt, Boolean acceptNothing, out Point3d point)

```

```csharp
public static Result GetPointOnMesh(RhinoDoc doc, MeshObject meshObject, String prompt, Boolean acceptNothing, out Point3d point)

```

```csharp
public static Result GetPointOnMesh(RhinoDoc doc, Guid meshObjectId, String prompt, Boolean acceptNothing, out Point3d point)

```

```csharp
public static Result GetPointOnMesh(Guid meshObjectId, String prompt, Boolean acceptNothing, out Point3d point)

```

--------------------------------

### Get ParentId of DimensionStyle (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.dimensionstyle/parentid

This C# code snippet demonstrates how to retrieve the ParentId of a DimensionStyle object. The ParentId is a Guid that identifies the parent style. It is available from Rhino version 6.0 onwards.

```csharp
System.Guid parentId = dimensionStyle.ParentId;
```

--------------------------------

### LicenseLease Constructor (IntPtr)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.licenselease/licenselease

Initializes a new instance of the LicenseLease class using an unmanaged pointer. This constructor is available since version 6.0.

```APIDOC
## LicenseLease(IntPtr unmanagedPointer)

### Description
Initializes a new instance of the LicenseLease class using an unmanaged pointer.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
*   **unmanagedPointer** (IntPtr) - Required - The unmanaged pointer to initialize the LicenseLease with.

### Request Example
None (Constructor)

### Response
#### Success Response (N/A)
N/A (Constructor)

#### Response Example
None (Constructor)

### Remarks
Available since: 6.0
```

--------------------------------

### File3dmPlugInDataTable.Dump()

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmplugindatatable/dump

Prepares and returns a string containing a text dump of the table data within the File3dmPlugInDataTable.

```APIDOC
## File3dmPlugInDataTable.Dump()

### Description
Prepares a text dump of the table.

### Method
`public String Dump()`

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Returns)
- **String** - A string containing the dump of the table data.

#### Response Example
```json
{
  "example": "Table dump string content..."
}
```

### Availability
Available since version 5.0.
```

--------------------------------

### DimensionStyle.ArrowBlockId1 Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.dimensionstyle/arrowblockid1

The ArrowBlockId1 property of the DimensionStyle class allows you to get or set the unique identifier (Guid) for the arrow block used in dimension styles. This property is available since version 6.0 of the RhinoCommon API.

```APIDOC
## DimensionStyle.ArrowBlockId1 Property

### Description
Gets or sets the Guid for the arrow block associated with this dimension style.

### Method
Property (get|set)

### Endpoint
Rhino.DocObjects.DimensionStyle.ArrowBlockId1

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```json
{
  "example": "Not applicable for property access"
}
```

### Response
#### Success Response (200)
- **ArrowBlockId1** (Guid) - The Guid of the arrow block.

#### Response Example
```json
{
  "example": "a1b2c3d4-e5f6-7890-1234-567890abcdef"
}
```

### Remarks
Available since RhinoCommon 6.0.
```

--------------------------------

### Get/Set ArrowHeadWidth (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.gumball.gumballappearancesettings/arrowheadwidth

The ArrowHeadWidth property in the GumballAppearanceSettings class allows you to get or set the width of the arrowhead in pixels. This property is of type int and is available starting from RhinoCommon version 5.0.

```csharp
public int ArrowHeadWidth {get|set}
```

--------------------------------

### Loft Curves using RhinoCommon API in C#

Source: https://developer.rhino3d.com/api/rhinocommon/examples/loft

This C# code snippet demonstrates how to select multiple curves from the Rhino document and create a lofted Brep surface. It utilizes RhinoCommon's GetObject for user selection and Brep.CreateFromLoft for generating the loft. Ensure at least two curves are selected.

```csharp
using System.Linq;
using Rhino;
using Rhino.Input.Custom;
using Rhino.DocObjects;
using Rhino.Commands;
using Rhino.Geometry;

namespace examples_cs
{
  public class LoftCommand : Command
  {
    public override string EnglishName { get { return "csLoft"; } }

    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
      // select curves to loft
      var gs = new GetObject();
      gs.SetCommandPrompt("select curves to loft");
      gs.GeometryFilter = ObjectType.Curve;
      gs.DisablePreSelect();
      gs.SubObjectSelect = false;
      gs.GetMultiple(2, 0);
      if (gs.CommandResult() != Result.Success)
        return gs.CommandResult();

      var curves = gs.Objects().Select(obj => obj.Curve()).ToList();

      var breps = Brep.CreateFromLoft(curves, Point3d.Unset, Point3d.Unset, LoftType.Tight, false);
      foreach (var brep in breps)
        doc.Objects.AddBrep(brep);

      doc.Views.Redraw();
      return Result.Success;
    }
  }
}
```

--------------------------------

### Get Degree Symbol Character (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.symbols/degreesymbol

Retrieves the character representing the degree symbol. This is a static read-only property of the `Rhino.Symbols` class. It is available starting from version 6.0 of RhinoCommon.

```csharp
public static char DegreeSymbol {get}
```

--------------------------------

### DevelopableSrf Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.developablesrf/developablesrf

Initializes a new instance of the DevelopableSrf class.

```APIDOC
## DevelopableSrf Constructor

### Description
Initializes a new instance of the DevelopableSrf class.

### Method
`DevelopableSrf()`

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
```json
{
  "constructor": "DevelopableSrf()"
}
```

### Response
#### Success Response (200)
- **DevelopableSrf** (DevelopableSrf) - A new instance of the DevelopableSrf class.

#### Response Example
```json
{
  "instance": "<DevelopableSrf object>"
}
```
```

--------------------------------

### Get Constant Pointer (C#) - RhinoCommon

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.simulatedtexture/constpointer

The ConstPointer method returns an IntPtr to the constant pointer of a SimulatedTexture object. This method is part of the Rhino.Render namespace and is available starting from version 5.1 of RhinoCommon.

```csharp
public IntPtr ConstPointer()
{
  // Implementation details for returning the constant pointer
  return IntPtr.Zero; // Placeholder
}
```

--------------------------------

### Construct ViewCaptureSettings from RhinoView and Media Size

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.viewcapturesettings/viewcapturesettings

Initializes ViewCaptureSettings using a RhinoView, a media size, and a DPI value. This constructor is ideal for capturing or printing a specific view with control over the output media dimensions and resolution.

```csharp
public ViewCaptureSettings(
  RhinoView sourceView,
  Size mediaSize,
  double dpi
)

```

--------------------------------

### Initialize ZooClient and Rhino License Manager (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.hostutils/initializezooclient

Initializes the ZooClient and Rhino license manager. This method is usually called automatically upon RhinoCommon loading and typically does not require manual invocation. It returns void and is available since version 5.6.

```csharp
public static Void InitializeZooClient()
```

--------------------------------

### Get Metallic Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.childslotnames.physicallybased/metallic

Retrieves the string value representing the Metallic property. This is a static property within the Rhino.Render.ChildSlotNames.PhysicallyBased class. It is available starting from Rhino version 7.0.

```csharp
public static string Metallic { get; }
```

--------------------------------

### Create Brep from Loft with Rebuild (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createfromloftrebuild

Constructs one or more Breps by lofting through a set of curves. Input curves are rebuilt to a specified number of control points. This overload does not include the angle tolerance parameter.

```csharp
public static Brep[] CreateFromLoftRebuild(
  IEnumerable<Curve> curves,
  Point3d start,
  Point3d end,
  LoftType loftType,
  Boolean closed,
  Int32 rebuildPointCount
)
```

--------------------------------

### Get Opacity Property (RhinoCommon API)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.childslotnames.physicallybased/opacity

Retrieves the current value of the Opacity property. This property is a string that indicates the opacity setting. It is available starting from Rhino version 7.0.

```csharp
public static string Opacity {get}
```

--------------------------------

### Get Plug-in Creator Organization Address (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugininfo/address

Retrieves the address of the organization that created the plug-in. This property is of type string and is read-only. It is available starting from version 6.0 of RhinoCommon.

```csharp
public string Address { get; }
```

--------------------------------

### Light() Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.light/light

Initializes a new instance of the Light class.

```APIDOC
## Light()

### Description
Initializes a new instance of the Light class.

### Method
**public**

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Example
```csharp
Rhino.Geometry.Light newLight = new Rhino.Geometry.Light();
```

### Response
#### Success Response (N/A)
N/A

#### Response Example
N/A

### Remarks
Available since version 5.0.
```

--------------------------------

### FileXamlWriteOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filexamlwriteoptions/filexamlwriteoptions

Initializes a new instance of the FileXamlWriteOptions class. This class is used to configure options for writing XAML files.

```APIDOC
## FileXamlWriteOptions()

### Description
Initializes a new instance of the FileXamlWriteOptions class.

### Method
Constructor

### Endpoint
N/A

### Parameters
None

### Request Example
```json
{
  "example": "new FileXamlWriteOptions()"
}
```

### Response
#### Success Response (200)
- **FileXamlWriteOptions** (Object) - An initialized instance of the FileXamlWriteOptions class.

#### Response Example
```json
{
  "example": "{...}" 
}
```
```

--------------------------------

### MatchSrfSettings Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.matchsrfsettings/matchsrfsettings

This constructor initializes a new instance of the MatchSrfSettings class, specifying continuity settings for surface matching.

```APIDOC
## MatchSrfSettings Constructor

### Description
Initializes a new instance of the MatchSrfSettings class with specified continuity settings.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
**match** (Continuity) - Required - The continuity setting for the primary match.
**otherEnd** (Continuity) - Required - The continuity setting for the other end of the match.

### Request Example
```csharp
Continuity continuity1 = Continuity.G1;
Continuity continuity2 = Continuity.G2;
Rhino.Geometry.MatchSrfSettings settings = new Rhino.Geometry.MatchSrfSettings(continuity1, continuity2);
```

### Response
#### Success Response (200)
N/A (Constructor)

#### Response Example
N/A (Constructor)
```

--------------------------------

### Get Unset MeshFace (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.meshface/unset

Retrieves a MeshFace with unset corner indices. Unset faces are represented by Int32.MinValue for all corner indices. This property is available starting from version 5.0.

```csharp
public static MeshFace Unset { get; }
```

--------------------------------

### GetPluginSettings Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.plugins.plugin/getpluginsettings

This method retrieves persistent settings for a given plugin. It allows specifying whether to load the settings if they are not already in memory.

```APIDOC
## Rhino.PlugIns.PlugIn.GetPluginSettings

### Description
Retrieves persistent settings for a specific plugin. Optionally loads the settings if they are not already available.

### Method
`public static PersistentSettings GetPluginSettings(Guid plugInId, Boolean load)`

### Endpoint
N/A (This is a static method within the RhinoCommon library, not a web API endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
// Example usage:
Guid myPluginId = new Guid("YOUR_PLUGIN_GUID");
bool shouldLoad = true;
PersistentSettings settings = Rhino.PlugIns.PlugIn.GetPluginSettings(myPluginId, shouldLoad);
```

### Response
#### Success Response
- **PersistentSettings** (Type) - An object containing the persistent settings for the specified plugin.

#### Response Example
```json
{
  "example": "PersistentSettings object containing plugin configurations"
}
```

### Remarks
- Available since Rhino version 6.0.
- The `plugInId` parameter uniquely identifies the plugin.
- The `load` parameter determines if the settings should be loaded from storage if not already in memory.
```

--------------------------------

### FileVdaWriteOptions Address Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filevdawriteoptions/address

The Address property of the FileVdaWriteOptions class allows you to get or set a string value representing an address. This property is available starting from version 8.0.

```APIDOC
## FileVdaWriteOptions Address Property

### Description
Represents an address associated with file writing options.

### Class
Rhino.FileIO.FileVdaWriteOptions

### Syntax
public string Address {get|set}

### Returns
- **string**: The address value.

### Available since
8.0
```

--------------------------------

### ColorStop Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.colorstop/colorstop

Creates a new ColorStop object with the specified color and position.

```APIDOC
## ColorStop Constructor

### Description
Creates a color stop from a color and position.

### Method
Constructor

### Endpoint
Rhino.Display.ColorStop.ColorStop

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **color** (Color) - Required - The color for the stop.
- **t** (double) - Required - The position of the color stop, typically between 0.0 and 1.0.

### Request Example
```json
{
  "color": "(255, 0, 0)",
  "t": 0.5
}
```

### Response
#### Success Response (200)
Represents a color stop in a gradient.

#### Response Example
```json
{
  "color": "(255, 0, 0)",
  "t": 0.5
}
```
```

--------------------------------

### Get Hair Density (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.curvaturegraphsettings/hairdensity

Retrieves the current hair density setting. This property returns an integer value representing the hair density. It is available starting from Rhino version 8.0.

```csharp
int currentHairDensity = Rhino.ApplicationSettings.CurvatureGraphSettings.HairDensity;
```

--------------------------------

### Get Object Description using Rhino3D API

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Provides an example of selecting a single object using `rhinoscriptsyntax.GetObject` and then retrieving its text description using `rhinoscriptsyntax.ObjectDescription`. The description is then printed to the console.

```python
import rhinoscriptsyntax as rs
obj = rs.GetObject("Select object")
if obj:
    description = rs.ObjectDescription(obj)
    print("Object description:"{} .format(description))
```

--------------------------------

### SimpleArrayArrayPoint3d Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.interopwrappers.simplearrayarraypoint3d/simplearrayarraypoint3d

Initializes a new empty SimpleArrayArrayPoint3d instance.

```APIDOC
## SimpleArrayArrayPoint3d()

### Description
Initializes a new empty SimpleArrayArrayPoint3d instance.

### Method
GET

### Endpoint
/Rhino.Runtime.InteropWrappers/SimpleArrayArrayPoint3d()

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
- **instance** (SimpleArrayArrayPoint3d) - A new, empty instance of SimpleArrayArrayPoint3d.

#### Response Example
{
  "instance": "<empty SimpleArrayArrayPoint3d object>"
}
```

--------------------------------

### Get One License Status (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.izooclientutilities/getonelicensestatus

Retrieves the current license status for a given product, intended for UI display. This method requires a product ID (Guid) and an object for verification. It returns a LicenseStatus enumeration value.

```csharp
public LicenseStatus GetOneLicenseStatus(object verify, Guid productId)
```

--------------------------------

### SimpleArrayBrepPointer Methods

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Runtime_InteropWrappers_SimpleArrayBrepPointer

Methods available for the SimpleArrayBrepPointer class.

```APIDOC
## Add(Brep brep, Boolean asConst) Method

### Description
Adds a brep to the list.

### Method
POST

### Endpoint
N/A

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **brep** (Brep) - The brep to add.
- **asConst** (Boolean) - True to add as a constant pointer, false otherwise.

### Request Example
```json
{
  "brep": "<Brep Object>",
  "asConst": false
}
```

### Response
#### Success Response (200)
None

#### Response Example
None
```

```APIDOC
## ConstPointer() Method

### Description
Gets the constant (immutable) pointer of this array.

### Method
GET

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
- **Pointer** (PointerType) - The constant pointer to the array.

#### Response Example
```json
{
  "Pointer": "<Pointer Address>"
}
```
```

```APIDOC
## Dispose() Method

### Description
Actively reclaims unmanaged resources that this instance uses.

### Method
DELETE

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
None

#### Response Example
None
```

```APIDOC
## Dispose(Boolean disposing) Method

### Description
Disposes of the resources used by the instance.

### Method
DELETE

### Endpoint
N/A

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **disposing** (Boolean) - True to release both managed and unmanaged resources; false to release only unmanaged resources.

### Request Example
```json
{
  "disposing": true
}
```

### Response
#### Success Response (200)
None

#### Response Example
None
```

```APIDOC
## NonConstPointer() Method

### Description
Gets the non-constant pointer (for modification) of this array.

### Method
GET

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
- **Pointer** (PointerType) - The non-constant pointer to the array.

#### Response Example
```json
{
  "Pointer": "<Pointer Address>"
}
```
```

```APIDOC
## ToNonConstArray() Method

### Description
Copies the unmanaged array to a managed counterpart.

### Method
GET

### Endpoint
N/A

### Parameters
None

### Request Example
None

### Response
#### Success Response (200)
- **Array** (ManagedArrayType) - A managed array containing the elements from the unmanaged array.

#### Response Example
```json
{
  "Array": [
    "<Element 1>",
    "<Element 2>"
  ]
}
```
```

--------------------------------

### ObjRef.CurveParameter Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.objref/curveparameter

Gets the parameter of a selection point if the reference geometry is a curve or edge. If a curve was selected and CurveParameter is called and the SelectionMethod() is not 1 (point pick on object), the curve will be returned and parameter will be set to the start parameter of the picked curve. This can be misleading so it may be necessary to call SelectionMethod() first, before calling CurveParameter to get the desired information.

```APIDOC
## ObjRef.CurveParameter Method

### Description
If the reference geometry is a curve or edge with a selection point, then this gets the parameter of the selection point.

### Method
`public Curve CurveParameter(out Double parameter)`

### Endpoint
Rhino.DocObjects.ObjRef

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
- **parameter** (System.Double) - The parameter of the selection point.
- **Return Value** (Curve) - If the selection point was on a curve or edge, then the curve/edge is returned, otherwise null.

#### Response Example
None

### Remarks
If a curve was selected and CurveParameter is called and the SelectionMethod() is not 1 (point pick on object), the curve will be returned and parameter will be set to the start parameter of the picked curve. This can be misleading so it may be necessary to call SelectionMethod() first, before calling CurveParameter to get the desired information.

### Available since
5.0
```

--------------------------------

### SetupDisplayMaterial with Color | RhinoCommon C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaypipeline/setupdisplaymaterial

Sets up a display material using a specified color. This overload is available since version 8.0 and returns a DisplayMaterial.

```csharp
public DisplayMaterial SetupDisplayMaterial(
  Color color
)
```

--------------------------------

### Get Editor UUID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.controls.contentui/editoruuid

Retrieves the unique identifier of the editor hosting the UI. This method is part of the Rhino.UI.Controls.ContentUI class and returns a Guid. It is available in RhinoCommon version 7.11 and later.

```csharp
public virtual Guid EditorUuid()
{
  // Implementation returns the unique identifier of the editor.
}
```

--------------------------------

### Get Active Command ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.rhinodoc/activecommandid

Retrieves the unique identifier (Guid) of the command that is currently active in the Rhino environment. This property is read-only and available since Rhino version 8.0.

```csharp
System.Guid activeCommandId = Rhino.RhinoDoc.ActiveCommandId;
```

--------------------------------

### Rhino.UI.RuiUpdateUi - RegisterMenuItem (String overload)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.ruiupdateui/registermenuitem

Registers a menu item update delegate using String identifiers for file, menu, and item.

```APIDOC
## POST /websites/developer_rhino3d_api/Rhino.UI/RuiUpdateUi/RegisterMenuItem

### Description
Registers a menu item update delegate using String identifiers.

### Method
POST

### Endpoint
/websites/developer_rhino3d_api/Rhino.UI/RuiUpdateUi/RegisterMenuItem

### Parameters
#### Query Parameters
- **fileId** (System.String) - Required - Menu file Id
- **menuId** (System.String) - Required - Menu Id
- **itemId** (System.String) - Required - Menu item Id
- **callBack** (UpdateMenuItemEventHandler) - Required - Callback function to handle menu item updates

### Request Body
(This endpoint does not have a request body)

### Response
#### Success Response (200)
- **Boolean** - True if Registered otherwise false

#### Response Example
```json
{
  "success": true
}
```
```

--------------------------------

### Get Render Environment ID (RhinoCommon C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendersettings/renderenvironmentid

Retrieves the GUID of a render environment based on its usage and purpose. Returns Guid.Empty for specific background modes. Requires RhinoCommon library.

```csharp
public Guid RenderEnvironmentId(
  EnvironmentUsage usage,
  EnvironmentPurpose purpose
)
```

--------------------------------

### File3dm Methods

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_FileIO_File3dm

Provides methods for interacting with the .3dm file, such as reading from a byte array, getting a preview image, and validating the file.

```APIDOC
## File3dm Methods

### Description
Methods for performing operations on the File3dm object, including reading, validation, and data export.

### Method
GET/POST/etc. (depending on method)

### Endpoint
N/A (Methods)

### Parameters
None (for general description; specific methods have parameters)

### Methods List:
- **Audit**(Boolean attemptRepair, Int32 repairCount, String errors, Int32[] warnings): This function is only kept for forward assembly compatibility.
- **Dispose**(): Actively reclaims unmanaged resources that this instance uses.
- **Dispose**(Boolean disposing): Called with argument True when class user calls Dispose(), while with argument False when the Garbage Collector invokes the finalizer.
- **Dump**(): Prepares a text dump of the entire model.
- **DumpSummary**(): Prepares a text dump of model properties and settings.
- **DumpToTextLog**(TextLog log): Prepares a text dump of the entire model.
- **FromByteArray**(Byte[] bytes): Read a 3dm file from a byte array.
- **GetPreviewImage**(): Preview image used for file explorer.
- **IsValid**(String errors): The File3dm object is kept consistent during its creation. Therefore, this function now returns only true.
- **IsValid**(TextLog errors): The File3dm object is kept consistent during its creation. Therefore, this function now returns only true.
- **Polish**(): This function is only kept for forward assembly compatibility.
- **Read**(String path, TableTypeFilter tableTypeFilterFilter, ObjectTypeFilter objectTypeFilter): Reads a .3dm file from the specified path.

### Request Example
```json
{
  "example": "Example for Read method: Read('path/to/file.3dm', TableTypeFilter.All, ObjectTypeFilter.All)"
}
```

### Response
Depends on the method called. For `Read`, it would return a File3dm object or indicate success/failure.

### Response Example
```json
{
  "example": "Success response for Read method indicates the file was loaded."
}
```
```

--------------------------------

### Get Decal Texture ID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.decal/textureinstanceid

Retrieves the unique identifier (Guid) for the texture applied to a decal object. This property is read-only and available since RhinoCommon version 5.10.

```csharp
public Guid TextureInstanceId { get; }
```

--------------------------------

### ViewTable.Add Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.tables.viewtable/add

Constructs a new Rhino view and adds it to the list.

```APIDOC
## Add Method

### Description
Constructs a new Rhino view and, at the same time, adds it to the list.

### Method
POST

### Endpoint
/websites/developer_rhino3d_api/Rhino.DocObjects.Tables/ViewTable/Add

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **title** (String) - Required - The title of the new Rhino view.
- **projection** (DefinedViewportProjection) - Required - A basic projection type.
- **position** (System.Drawing.Rectangle) - Required - A position.
- **floating** (Boolean) - Required - True if the view floats; False if it is docked.

### Request Example
```json
{
  "title": "MyView",
  "projection": "Top",
  "position": {"X": 0, "Y": 0, "Width": 800, "Height": 600},
  "floating": false
}
```

### Response
#### Success Response (200)
- **RhinoView** (Object) - The newly constructed Rhino view.

#### Response Example
```json
{
  "title": "MyView",
  "projection": "Top",
  "position": {"X": 0, "Y": 0, "Width": 800, "Height": 600},
  "floating": false,
  "id": 1
}
```

#### Error Response
- **None** - Returned on error.

### Availability
- Available since: 5.0
```

--------------------------------

### Initialize ZooClientParameters Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.zooclientparameters/zooclientparameters

The ZooClientParameters constructor is used to create an instance of ZooClientParameters. This object holds all the necessary information for a product to communicate with ZooClient for license management. It includes details like product GUIDs, license types, validation delegates, and UI related parameters.

```csharp
public ZooClientParameters(
  Guid productGuid,
  Guid licenseGuid,
  string productTitle,
  int productBuildType,
  LicenseCapabilities capabilities,
  string licenseEntryTextMask,
  string productPath,
  object parentWindow,
  LicenseTypes selectedLicenseType,
  ValidateProductKeyDelegate validateProductKey,
  OnLeaseChangedDelegate onLeaseChangedDelegate,
  VerifyLicenseKeyDelegate verifyLicenseKeyDelegate,
  VerifyPreviousVersionLicenseKeyDelegate verifyPreviousVersionLicenseKeyDelegate
)
```

--------------------------------

### Get ObjectId of RenderMeshes Object (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.customrendermeshes.rendermeshes/objectid

This snippet demonstrates how to access the ObjectId property of a RenderMeshes object in C#. The ObjectId is a Guid that uniquely identifies the IRenderMeshes object. This property is read-only.

```csharp
using Rhino.Render.CustomRenderMeshes;

// Assuming 'renderMeshes' is an instance of the RenderMeshes class
Guid objectId = renderMeshes.ObjectId;
System.Console.WriteLine($"ObjectId: {objectId}");
```

--------------------------------

### Set or Get Current Rhino Layer

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Returns the current layer name or changes the current layer to a specified layer. The layer can be identified by its name or GUID. This function requires the rhinoscriptsyntax library.

```python
import rhinoscriptsyntax as rs

rs.AddLayer("MyLayer")
rs.CurrentLayer("MyLayer")
```

--------------------------------

### AddOption (overload 3)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getbaseclass/addoption

Adds a command line option with a localized name.

```APIDOC
## POST /AddOption

### Description
Adds a command line option with a localized name.

### Method
POST

### Endpoint
/AddOption

### Parameters
#### Request Body
- **optionName** (LocalizeStringPair) - Required - Must only consist of letters and numbers (no characters list periods, spaces, or dashes).

### Response
#### Success Response (200)
- **return_value** (Int32) - Option index value (>0) or 0 if option cannot be added.

Available since: 5.0
```

--------------------------------

### Get Plugin Identifier

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Retrieves the unique identifier (GUID) of a Rhino plug-in given its name. If the plug-in is not valid or not found, it returns None. This is useful for programmatic access to specific plug-in functionalities.

```python
import rhinoscriptsyntax as rs
plugins = rs.PlugIns(0, 1)
if plugins:
    for plugin in plugins: print(rs.PlugInId(plugin))
```

--------------------------------

### Get RenderedId Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.displaymodedescription/renderedid

This C# code snippet demonstrates how to access the static RenderedId property of the DisplayModeDescription class. The property returns a Guid, which is the identifier for the rendered display mode. This property is read-only.

```csharp
using System;
using Rhino.Display;

public class Example
{
    public void GetRenderedId()
    {
        Guid renderedId = DisplayModeDescription.RenderedId;
        Console.WriteLine($"Rendered ID: {renderedId}");
    }
}
```

--------------------------------

### Get Texture Size (RhinoCommon API)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.supportoptions/texturesize

The TextureSize method is a static method within the Rhino.Render.SupportOptions class. It returns an Int32 representing the texture size. This method is available starting from Rhino version 6.0.

```csharp
public static Int32 TextureSize()
```

--------------------------------

### Initialize PreviewBackground (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.previewbackground/previewbackground

This C# constructor initializes a new instance of the PreviewBackground class. It requires an IntPtr representing the preview background object. This method is available from RhinoCommon version 6.0 onwards.

```csharp
public PreviewBackground(IntPtr pPreviewBackground)
```

--------------------------------

### ShowGrid Property

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.constructionplane/showgrid

Gets or sets whether the grid itself should be visible.

```APIDOC
## ShowGrid Property

### Description
Gets or sets whether the grid itself should be visible.

### Method
`get` or `set`

### Endpoint
`Rhino.DocObjects.ConstructionPlane.ShowGrid`

### Parameters
This is a property, not an endpoint with parameters.

### Request Example
```json
{
  "example": "// To get the visibility\nbool isVisible = constructionPlane.ShowGrid;\n// To set the visibility\nconstructionPlane.ShowGrid = true;"
}
```

### Response
#### Success Response (200)
- **Type**: `bool` - True if the grid is visible, false otherwise.

#### Response Example
```json
{
  "example": "true"
}
```

### Remarks
Available since RhinoCommon version 5.0.
```

--------------------------------

### Get String from BackgroundProjections (RhinoCommon C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.simulatedenvironment/stringfromprojection

The StringFromProjection method converts a BackgroundProjections enum value to its string representation. This is useful for display or serialization purposes. It is available starting from version 5.1 of RhinoCommon.

```csharp
public static String StringFromProjection(
  BackgroundProjections projection
)
```

--------------------------------

### CollapsibleSectionImpl.Factory Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.controls.collapsiblesectionimpl.factory/collapsiblesectionimpl

Initializes a new instance of the CollapsibleSectionImpl.Factory class.

```APIDOC
## CollapsibleSectionImpl.Factory()

### Description
Initializes a new instance of the CollapsibleSectionImpl.Factory class.

### Method
CONSTRUCTOR

### Endpoint
N/A (Constructor)

### Parameters
None

### Request Body
None

### Response
#### Success Response (N/A)
N/A (Constructor)

#### Response Example
N/A (Constructor)
```

--------------------------------

### InstanceDefinitionGeometry.UrlDescription

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.instancedefinitiongeometry/urldescription

Gets or sets the description of the URL or hyperlink of the definition.

```APIDOC
## InstanceDefinitionGeometry.UrlDescription

### Description
Gets or sets the description of the URL or hyperlink of the definition.

### Method
{get|set}

### Endpoint
Rhino.Geometry/InstanceDefinitionGeometry/UrlDescription

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
This property is accessed directly on an InstanceDefinitionGeometry object.

### Response
#### Success Response (200)
- **UrlDescription** (string) - The description of the URL or hyperlink.

#### Response Example
```json
{
  "UrlDescription": "A brief description of the linked resource."
}
```
```

--------------------------------

### Get TypeName Property from RenderContent Class (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.rendercontent/typename

Retrieves the name of the content type from the RenderContent class in the Rhino.Render namespace. This property is of type String and was made available starting from version 5.1.

```csharp
public abstract String TypeName {get}
```

--------------------------------

### Rhino.UI.Dialogs.ShowTextDialog

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.dialogs/showtextdialog

This method displays a text dialog, similar to the 'What' command in Rhino.

```APIDOC
## Rhino.UI.Dialogs.ShowTextDialog

### Description
Displays a text dialog similar to the dialog used for the "What" command.

### Method
Public static Void

### Endpoint
Not applicable (this is a method call within the RhinoCommon API).

### Parameters
#### Method Parameters
- **message** (System.String) - Required - Text to display as the message content.
- **title** (System.String) - Required - Text to display as the form title.

### Request Example
```csharp
Rhino.UI.Dialogs.ShowTextDialog("This is the message content.", "Dialog Title");
```

### Response
#### Success Response
Type: Void

#### Response Example
(This method does not return a value.)
```

--------------------------------

### FileCdWriteOptions Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.filecdwriteoptions/filecdwriteoptions

Initializes a new instance of the FileCdWriteOptions class. This constructor does not take any arguments.

```APIDOC
## FileCdWriteOptions()

### Description
Initializes a new instance of the FileCdWriteOptions class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response (Instance)
- **FileCdWriteOptions** (FileCdWriteOptions) - An initialized instance of the FileCdWriteOptions class.

#### Response Example
```json
{
  "instance": "Rhino.FileIO.FileCdWriteOptions"
}
```
```

--------------------------------

### Get BaseColor Property (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.childslotnames.physicallybased/basecolor

Retrieves the base color as a string from the PhysicallyBased class in the Rhino.Render namespace. This property is available starting from version 7.0. It is a static property with a read-only accessor.

```csharp
public static string BaseColor { get; }
```

--------------------------------

### ZebraAnalysisSettingsState Methods

Source: https://developer.rhino3d.com/api/rhinocommon/references/rhino.applicationsettings

Provides methods to get the current and default states of ZebraAnalysisSettings, and to update settings from a given state.

```APIDOC
## ZebraAnalysisSettingsState Methods

### Description
This section details the methods available for managing the state of ZebraAnalysisSettings.

### Methods

#### GetCurrentState
- **Description**: Retrieves the current state of the ZebraAnalysisSettings.
- **Method**: GET
- **Endpoint**: N/A (Method within a class)
- **Parameters**: None

#### GetDefaultState
- **Description**: Retrieves the default state of the ZebraAnalysisSettings.
- **Method**: GET
- **Endpoint**: N/A (Method within a class)
- **Parameters**: None

#### UpdateFromState
- **Description**: Updates the ZebraAnalysisSettings from a provided ZebraAnalysisSettingsState.
- **Method**: POST (or PUT, depending on convention for state updates)
- **Endpoint**: N/A (Method within a class)
- **Parameters**:
  - **Path Parameters**: None
  - **Query Parameters**: None
  - **Request Body**: 
    - **state** (ZebraAnalysisSettingsState) - Required - The state to update from.

### Request Example (for UpdateFromState)
```json
{
  "state": { ... } 
}
```

### Response (for GetCurrentState/GetDefaultState)
#### Success Response (200)
- **state** (ZebraAnalysisSettingsState) - The current or default state of ZebraAnalysisSettings.

### Response Example (for GetCurrentState/GetDefaultState)
```json
{
  "state": { ... } 
}
```
```

--------------------------------

### BoundingBox Constructor Overloads

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.boundingbox/boundingbox

This section details the different constructors available for the BoundingBox class in RhinoCommon.

```APIDOC
## BoundingBox Constructors

### Description
Constructs a bounding box from numeric extremes.

### Method
Constructor

### Endpoint
Rhino.Geometry.BoundingBox

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
None

#### Response Example
None

---

### Description
Constructs a bounding box from a collection of points and a transformation.

### Method
Constructor

### Endpoint
Rhino.Geometry.BoundingBox

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
None

#### Response Example
None

---

### Description
Constructs a bounding box from a collection of points.

### Method
Constructor

### Endpoint
Rhino.Geometry.BoundingBox

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
None

#### Response Example
None

---

### Description
Constructs a new bounding box from two corner points.

### Method
Constructor

### Endpoint
Rhino.Geometry.BoundingBox

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
None

### Response
#### Success Response (200)
None

#### Response Example
None
```

--------------------------------

### Get Edge Count of a SubD Face (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.subdface/edgecount

Retrieves the number of edges belonging to a SubD face. This property is read-only and mirrors the vertex count for the face. It is available starting from Rhino version 7.0.

```csharp
public int EdgeCount { get; }
```

--------------------------------

### Accessing OffsetPlaneVector3d Property (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.ribbonoffsetparameters/offsetplanevector3d

Demonstrates how to get or set the OffsetPlaneVector3d property of a RibbonOffsetParameters object in C#. This vector defines the normal of the offset plane. Availability starts from version 8.9.

```csharp
using Rhino.Geometry;

// Assuming ribbonOffsetParameters is an instance of RibbonOffsetParameters

// Get the offset plane vector
Vector3d offsetPlaneNormal = ribbonOffsetParameters.OffsetPlaneVector3d;

// Set the offset plane vector
ribbonOffsetParameters.OffsetPlaneVector3d = new Vector3d(0, 0, 1); // Example: Z-axis normal
```

--------------------------------

### Brep.CreateQuadSphere

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.brep/createquadsphere

Constructs a Brep definition of a quad sphere. The input sphere provides the orienting plane and radius.

```APIDOC
## Brep.CreateQuadSphere

### Description
Constructs a Brep definition of a quad sphere. The input sphere provides the orienting plane and radius.

### Method
`public static Brep CreateQuadSphere(Sphere sphere)`

### Endpoint
N/A (This is a method within the RhinoCommon library, not a REST API endpoint)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
Sphere inputSphere = new Sphere(Plane.WorldXY, 5.0);
Brep quadSphere = Brep.CreateQuadSphere(inputSphere);
```

### Response
#### Success Response (Brep)
- **Brep** - A Brep representing the quad sphere.

#### Response Example
(Output is a Brep object, not a JSON response)

#### Error Response
- **None** - Returns None on error.

### Availability
Available since version 6.0
```

--------------------------------

### Light Class Documentation

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Light

This section details the properties and constructors available for the Light class in the Rhino3D API.

```APIDOC
## Light Class

Represents a light that shines in the modeling space.

### Inheritance
- Rhino.Runtime.CommonObject
- Rhino.Geometry.GeometryBase
- Light

### Namespace
Rhino.Geometry

### Constructors

- **CommonObject()**: Allows construction from inheriting classes.
- **CommonObject(SerializationInfo info, StreamingContext context)**: Protected constructor for internal use.
- **GeometryBase(SerializationInfo info, StreamingContext context)**: Protected constructor for internal use.
- **Light()**: Initializes a new light.
- **Light(SerializationInfo info, StreamingContext context)**: Protected constructor used in serialization.

### Properties

- **Ambient** (Color) - Gets or sets the ambient color.
- **AttenuationType** (AttenuationType) - Get the type of attenuation for this light.
- **AttenuationVector** (Vector3d) - Gets or Sets the attenuation vector.
- **CoordinateSystem** (CoordinateSystem) - Gets a value, determined by LightStyle, that explains whether the camera directions are relative to World or Camera spaces.
- **Diffuse** (Color) - Gets or sets the diffuse color.
- **Direction** (Vector3d) - Gets or sets the vector direction of the camera.
- **Disposed** (bool) - Indicates if this object has been disposed or the document it originally belonged to has been disposed.
- **HasBrepForm** (bool) - Returns True if the Brep.TryConvertBrep function will be successful for this object.
- **HasUserData** (bool) - Gets True if this class has any custom information attached to it through UserData.
- **HotSpot** (float) - The hot spot setting runs from 0.0 to 1.0 and is used to provides a linear interface for controlling the focus or concentration of a spotlight.
- **Id** (Guid) - Gets the ID of this light.
- **Intensity** (float) - Gets or sets the light intensity.
- **IsDeformable** (bool) - True if object can be accurately modified with "squishy" transformations like projections, shears, and non-uniform scaling.
- **IsDirectionalLight** (bool) - Gets a value indicating whether the light style is LightStyle CameraDirectional or WorldDirectional.
- **IsDocumentControlled** (bool) - If True this object may not be modified. Any properties or functions that attempt to modify this object when it is set to "IsReadOnly" will throw a NotSupportedException.
- **IsEnabled** (bool) - Gets or sets a value that defines if the light is turned on (true) or off (false).
- **IsLinearLight** (bool) - Gets a value indicating whether the light style is LightStyle WorldLinear.
- **IsPointLight** (bool) - Gets a value indicating whether the light style is LightStyle CameraPoint or WorldPoint.
- **IsRectangularLight** (bool) - Gets a value indicating whether the light style is LightStyle WorldRectangular.
- **IsSpotLight** (bool) - Gets a value indicating whether the light style is LightStyle CameraSpot or WorldSpot.
- **IsSunLight** (bool) - Gets a value indicating whether this object is a Sun light.
- **IsValid** (bool) - Tests an object to see if it is valid.
- **Length** (float) - Gets or sets the height in linear and rectangular lights. (ignored for non-linear/rectangular lights.)
- **LightStyle** (LightStyle) - Gets or sets a light style on this camera.
- **Location** (Point3d) - Gets or sets the light or 3D position or location.
- **Name** (string) - Gets or sets the light name.
- **ObjectType** (ObjectType) - Useful for switch statements that need to differentiate between basic object types like points, curves, surfaces, and so on.
- **PerformCorruptionTesting** (bool) - Used to test ON_Object* pointers to see if they are a brep or mesh that is corrupt enough to crash Rhino.
- **PerpendicularDirection** (Vector3d) - Gets a perpendicular vector to the camera direction.
- **PowerCandela** (float) - Gets or sets the light power in candelas (cd).
- **PowerLumens** (float) - Gets or sets the light power in lumens (lm).
- **PowerWatts** (float) - Gets or sets the light power in watts (W).
- **ShadowIntensity** (float) - Gets or sets the shadow intensity for the light.
- **Specular** (Color) - Gets or sets the specular color.
- **SpotAngleRadians** (float) - Gets or sets the spot angle in radians. Ignored for non-spot lights. angle = 0 to pi/2 (0 to 90 degrees).
- **SpotExponent** (float) - The spot exponent varies from 0.0 to 128.0 and provides an exponential interface for controlling the focus or concentration of a spotlight.
- **SpotLightShadowIntensity** (float) - Shadow intensity specific to spotlights.
```

--------------------------------

### Get or Set Plane Origin Y Coordinate (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.plane/originy

Retrieves or modifies the Y-coordinate of the origin of a Rhino.Geometry.Plane object. This property is of type double and is available starting from RhinoCommon version 5.0.

```csharp
public double OriginY {get|set}
```

--------------------------------

### Rhino.Render.LightManagerSupportClient.LightDescription

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.lightmanagersupportclient/lightdescription

This method retrieves a string description of a given light object.

```APIDOC
## Rhino.Render.LightManagerSupportClient.LightDescription

### Description
Retrieves a string description of a given light object.

### Method
public String LightDescription(Light light)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
- **light** (Light) - The light object to describe.

### Request Example
```json
{
  "light": { /* Light object details */ }
}
```

### Response
#### Success Response (200)
- **return_value** (String) - A string representing the description of the light.

#### Response Example
```json
{
  "return_value": "This is a description of the light."
}
```

### Available since
6.0
```

--------------------------------

### Get Intersection Parameter on Curve A (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.intersect.intersectionevent/parametera

This property retrieves the parameter on Curve A at the point where an intersection occurred. If the intersection is an overlap, it returns the parameter corresponding to the start of the overlap region. The return type is a double.

```csharp
public double ParameterA {get}
```

--------------------------------

### Start a New Render Thread (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.asyncrendercontext/startrenderthread

Initiates a new render thread using a provided ThreadStart delegate and a string for the thread's name. This method is part of the Rhino.Render.AsyncRenderContext class and returns a boolean value indicating whether the thread was successfully started. Available since RhinoCommon 6.0.

```csharp
public Boolean StartRenderThread(ThreadStart threadStart, String threadName)
```

--------------------------------

### DracoCompression Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.dracocompression/dracocompression

Initializes a new instance of the DracoCompression class.

```APIDOC
## DracoCompression Constructor

### Description
Initializes a new instance of the DracoCompression class.

### Method
Constructor

### Endpoint
N/A (Class Constructor)

### Parameters
None

### Request Example
```json
{
  "example": "DracoCompression()"
}
```

### Response
#### Success Response (Instance)
- **DracoCompression** (DracoCompression) - An initialized instance of the DracoCompression class.

#### Response Example
```json
{
  "example": "// Instance created successfully"
}
```
```

--------------------------------

### Get Knot Style - C#

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.collections.nurbscurveknotlist/knotstyle

Retrieves the style of the knot vector from a NurbsCurveKnotList object. This property is read-only and returns a value of type KnotStyle. It is available starting from RhinoCommon version 7.1.

```csharp
public KnotStyle KnotStyle { get; }
```

--------------------------------

### Read .3dm File Start Section (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.binaryarchivereader/read3dmstartsection

Reads the start section of a .3dm file, extracting the file version and a comment string. This method is available since RhinoCommon 5.1 and returns true on success.

```csharp
public Boolean Read3dmStartSection(
  out Int32 version,
  out String comment
)
```

--------------------------------

### Get Control Vertex Count of BezierCurve (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.beziercurve/controlvertexcount

Retrieves the number of control vertices in a BezierCurve object. This property is read-only and returns an integer value. It is available starting from RhinoCommon version 5.0.

```csharp
public int ControlVertexCount {get}
```

--------------------------------

### SHA1OpenNURBS.Initialize Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.sha1opennurbs/initialize

Resets an instance of the algorithm for reuse. This method is part of the Rhino.FileIO.SHA1OpenNURBS class and is available since version 6.0.

```APIDOC
## SHA1OpenNURBS.Initialize Method

### Description
Resets this instance of the algorithm, so that it can be used again. It is not required to call this method after creation.

### Method
`public override Void Initialize()`

### Endpoint
Rhino.FileIO/SHA1OpenNURBS/Initialize

### Parameters
*No parameters are specified for this method.*

### Request Example
*Not applicable for this method.*

### Response
#### Success Response (Void)
*This method returns Void.*

#### Response Example
*Not applicable for this method.*

### Availability
Available since: 6.0
```

--------------------------------

### Get Enumerator for Views in RhinoCommon API

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.fileio.file3dmviewtable/getenumerator

This method returns an enumerator that yields all views present in the table. It is available starting from version 6.0 of the RhinoCommon API. The returned type is ViewInfo>.

```csharp
public ViewInfo> GetEnumerator()
{
    // Implementation details omitted
}
```

--------------------------------

### RenderPreCreateWindow Method

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderpipeline/renderprecreatewindow

Documentation for the RenderPreCreateWindow method in the Rhino.Render.RenderPipeline class. This method is used in the rendering process.

```APIDOC
## Rhino.Render.RenderPipeline.RenderPreCreateWindow Method

### Description
Provides information about the pre-creation window rendering process. The exact behavior and purpose are detailed in the full RhinoCommon documentation.

### Method
`protected virtual Boolean RenderPreCreateWindow()`

### Endpoint
N/A (This is a method within a class, not a REST endpoint)

### Parameters
None

### Request Example
N/A

### Response
#### Success Response
- **Boolean** - Returns `true` if the pre-creation window rendering is successful, `false` otherwise.

#### Response Example
```json
{
  "result": true
}
```
```

--------------------------------

### MetaData Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.datasources.metadata/metadata

Initializes a new instance of the MetaData class with the specified pointer.

```APIDOC
## MetaData constructor

### Description
Initializes a new instance of the `Rhino.Render.DataSources.MetaData` class.

### Method
public

### Endpoint
N/A (Constructor)

### Parameters
#### Path Parameters
None

#### Query Parameters
None

#### Request Body
None

### Request Example
```csharp
public MetaData(IntPtr pMetaData)
```

### Response
#### Success Response (N/A)
N/A

#### Response Example
N/A

### Remarks
Available since: 6.0
```

--------------------------------

### Get Default RUI File Path (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.applicationsettings.filesettings/defaultruifile

Retrieves the full path to the default RUI (Rhino User Interface) file. This property is read-only and available starting from RhinoCommon version 5.0.

```csharp
string ruiPath = Rhino.ApplicationSettings.FileSettings.DefaultRuiFile;
System.Console.WriteLine(ruiPath);
```

--------------------------------

### Check FullFrameRedrawDuringGet Value (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getpoint/fullframeredrawduringget

This C# example shows how to retrieve the current value of the FullFrameRedrawDuringGet property. Understanding this value is crucial for managing performance during interactive Get() operations in RhinoCommon.

```csharp
using Rhino.Input.Custom;

// ... assuming 'get' is an instance of GetPoint
bool redrawStatus = get.FullFrameRedrawDuringGet;
if (redrawStatus)
{
    // Full frame redraw is enabled
}
else
{
    // Full frame redraw is disabled
}
```

--------------------------------

### Initialize GetString Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.input.custom.getstring/getstring

Constructs a new instance of the GetString class. This is used for creating string input prompts within the Rhino environment. No specific dependencies are required beyond the RhinoCommon library.

```csharp
public GetString()

```

--------------------------------

### CollapsibleSectionImpl.Factory Class Documentation

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.ui.controls.collapsiblesectionimpl

Details about the CollapsibleSectionImpl.Factory class, its constructors, and methods.

```APIDOC
## CollapsibleSectionImpl.Factory Class

### Description
This class is part of the Rhino.UI.Controls namespace and provides factory methods for creating collapsible sections.

### Inheritance
- **Rhino.UI.Controls.FactoryBase**
- **CollapsibleSectionImpl.Factory**

### Derived Classes
None listed.

### Namespace
Rhino.UI.Controls

### Constructors
#### CollapsibleSectionImpl.Factory()
- **Description**: Initializes a new instance of the CollapsibleSectionImpl.Factory class.

### Methods
#### Get(Guid id)
- **Description**: Override this method to return a new instance of your class for the given ID.
- **Method**: Not specified (likely an instance method).

#### Register()
- **Description**: Call this function during startup of the current assembly to load classes with factory creation support.
- **Method**: Not specified (likely a static method).

#### Register(PlugIn plugin)
- **Description**: Call this function during the startup of your plug-in to ensure that all classes that support factory creation are registered.
- **Method**: Not specified (likely a static method).

### Request Example
```json
{
  "message": "No specific request examples available for this class documentation."
}
```

### Response
#### Success Response (200)
- **Description**: No specific success responses detailed for these methods. Refer to specific method implementations for expected return types.

#### Response Example
```json
{
  "message": "No specific response examples available for this class documentation."
}
```
```

--------------------------------

### Get Channel ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.renderwindow.channelgpu/id

The Id() method in the Rhino.Render.RenderWindow.ChannelGPU class returns the unique identifier for the GPU channel. This method is available since Rhino version 7.0. It takes no arguments and returns a Guid.

```csharp
public Guid Id()
```

--------------------------------

### Accessing ColorGradient StartPoint (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.colorgradient/startpoint

Demonstrates how to get or set the start point of a color gradient. The StartPoint property returns a Point3d object representing the gradient's origin. This property is available since Rhino version 7.0.

```csharp
public Point3d StartPoint { get; set; }
```

--------------------------------

### Get Post-Effect Execution Order (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.render.posteffects.posteffectpipeline/executionorder

The ExecutionOrder method returns an array of Guids representing the post-effects to be executed by this pipeline in their specified order. This method is available since Rhino version 7.0.

```csharp
public Guid[] ExecutionOrder()
{
  // Implementation details to retrieve and return the Guid array of post-effects
  return new Guid[0]; // Placeholder for actual implementation
}
```

--------------------------------

### TextFields Constructor

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.runtime.textfields/textfields

Initializes a new instance of the TextFields class.

```APIDOC
## TextFields()

### Description
Initializes a new instance of the TextFields class.

### Method
CONSTRUCTOR

### Endpoint
Rhino.Runtime.TextFields

### Parameters
This constructor does not take any parameters.

### Request Example
```json
{
  "example": "TextFields()"
}
```

### Response
#### Success Response (Instance)
- **TextFields** (object) - An instance of the TextFields class.

#### Response Example
```json
{
  "example": "new TextFields()"
}
```
```

--------------------------------

### Get Selected Objects in Rhino3D API

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Returns the identifiers of all currently selected objects in the document. It can optionally include light objects and grip objects. The function returns a list of GUIDs for the selected objects.

```python
import rhinoscriptsyntax as rs

objects = rs.SelectedObjects()
for obj in objects: print("Object identifier: {}".format(obj))
```

--------------------------------

### Point3dList.ZAccess

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.collections.point3dlist

Details about the Point3dList.ZAccess class, including its properties.

```APIDOC
## Point3dList.ZAccess Class

### Description
Utility class for easy-access of z-components of points inside an ON_3dPointList.

### Properties
#### Item
Gets or sets the z-coordinate of the specified point.

- **Item** (double) - Description: The z-coordinate of the point at the specified index.

### Request Example
```json
{
  "example": "Not applicable for this class"
}
```

### Response
#### Success Response (200)
- **Item** (double) - The z-coordinate of the point.

#### Response Example
```json
{
  "example": "Not applicable for this class"
}
```
```

--------------------------------

### Light Attenuation Method

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_Light

Method for getting light attenuation settings.

```APIDOC
## Light Attenuation Method

### Description
Retrieves the attenuation settings for lights, which affect how light intensity decreases with distance.

### Method

- **GetAttenuation**(Double d) - Gets the attenuation settings (ignored for "directional" and "ambient" lights). attenuation = 1/(a0 + d*a1 + d^2*a2) where d = distance to light.
```

--------------------------------

### Initialize Circle from Start Point, Tangent, and Point on Circle (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.geometry.circle/circle

Initializes a circle using a starting point, a tangent vector at that point, and another point that lies on the circle. This constructor may create an invalid circle. Available from version 5.0.

```csharp
public Circle(
  Point3d startPoint,
  Vector3d tangentAtP,
  Point3d pointOnCircle
)
```

--------------------------------

### Get Rhino Object Type

Source: https://developer.rhino3d.com/api/RhinoScriptSyntax

Retrieves the type of a specified Rhino object using its unique identifier (GUID). This function is essential for differentiating between various geometric object types within a Rhino scene.

```python
import rhinoscriptsyntax as rs

# Example: Getting the type of a selected object
obj_id = rs.GetObject("Select an object")
if obj_id:
    obj_type = rs.ObjectType(obj_id)
    print(f"The object type is: {obj_type}")
```

--------------------------------

### Get Current Dimension Style ID (RhinoCommon)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.docobjects.tables.dimstyletable/currentid

Retrieves the unique identifier (Guid) for the currently active dimension style in the Rhino document. This property is read-only and has been available since Rhino version 6.0.

```csharp
using Rhino.DocObjects.Tables;

// Assuming 'rhinoDoc' is an instance of RhinoDocument
Guid currentDimStyleId = rhinoDoc.DimStyles.CurrentId;
```

--------------------------------

### PointCloud Constructors

Source: https://developer.rhino3d.com/api/RhinoCommon/html/T_Rhino_Geometry_PointCloud

Details the various constructors available for creating instances of the PointCloud class, from empty clouds to those initialized with existing point data.

```APIDOC
## PointCloud Constructors

### Description
Provides methods for initializing a new PointCloud object.

### Constructors

*   **PointCloud()**
    Initializes a new, empty instance of the PointCloud class.

*   **PointCloud(IEnumerable<Point3d> points)**
    Initializes a new instance of the PointCloud class, copying data from a collection of Point3d objects.

*   **PointCloud(PointCloud other)**
    Initializes a new instance of the PointCloud class by merging the content of another PointCloud object.

*   **PointCloud(SerializationInfo info, StreamingContext context)**
    Protected constructor used for internal serialization purposes.

*   **GeometryBase(SerializationInfo info, StreamingContext context)**
    Protected constructor for GeometryBase, used internally.

*   **CommonObject()**
    Allows construction from inheriting classes.

*   **CommonObject(SerializationInfo info, StreamingContext context)**
    Protected constructor for internal use in CommonObject.
```

--------------------------------

### Get Active Detail ID (C#)

Source: https://developer.rhino3d.com/api/rhinocommon/rhino.display.rhinopageview/activedetailid

This C# code snippet demonstrates how to access the ActiveDetailId property of a RhinoPageView object to retrieve the Guid of the active detail. It handles the case where no detail is active by checking for Guid.Empty.

```csharp
using Rhino.Display;
using System;

// Assuming 'pageView' is an instance of RhinoPageView
RhinoPageView pageView = ...;

Guid activeDetailId = pageView.ActiveDetailId;

if (activeDetailId != Guid.Empty)
{
    // A detail is active, 'activeDetailId' holds its Guid
    Console.WriteLine($"Active Detail ID: {activeDetailId}");
}
else
{
    // No detail is active, or the page itself is active
    Console.WriteLine("No active detail found.");
}
```
