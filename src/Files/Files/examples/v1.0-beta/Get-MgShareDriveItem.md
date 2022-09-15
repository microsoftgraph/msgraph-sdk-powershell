### Example 1: Using the Get-MgShareDriveItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Files
Get-MgShareDriveItem -SharedDriveItemId $sharedDriveItemId -ExpandProperty "children" 
```
This example shows how to use the Get-MgShareDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgShareDriveItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Files
Get-MgShareDriveItem -SharedDriveItemId $sharedDriveItemId
```
This example shows how to use the Get-MgShareDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
