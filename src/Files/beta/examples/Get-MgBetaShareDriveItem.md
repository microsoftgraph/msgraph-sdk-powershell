### Example 1: Using the Get-MgBetaShareDriveItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Files
Get-MgBetaShareDriveItem -SharedDriveItemId $sharedDriveItemId -ExpandProperty "children" 
```
This example shows how to use the Get-MgBetaShareDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaShareDriveItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Files
Get-MgBetaShareDriveItem -SharedDriveItemId $sharedDriveItemId
```
This example shows how to use the Get-MgBetaShareDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
