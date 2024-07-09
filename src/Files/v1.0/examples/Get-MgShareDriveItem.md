### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

Get-MgShareDriveItem -SharedDriveItemId $sharedDriveItemId

```
This example shows how to use the Get-MgShareDriveItem Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

Get-MgShareDriveItem -SharedDriveItemId $sharedDriveItemId -ExpandProperty "children" 

```
This example shows how to use the Get-MgShareDriveItem Cmdlet.

