### Example 1: Get a bundle and its children in a single call

```powershell

Import-Module Microsoft.Graph.Files

Get-MgDriveItem -DriveId $driveId -DriveItemId $driveItemId -ExpandProperty "children" 

```
This example will get a bundle and its children in a single call

