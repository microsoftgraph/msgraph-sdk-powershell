### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Files

Get-MgBetaShareSharedDriveItemSharedDriveItem -SharedDriveItemId $sharedDriveItemId
```
This example shows how to use the Get-MgBetaBetaShareDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Files

Get-MgBetaShareDriveItem -SharedDriveItemId $sharedDriveItemId
```
This example shows how to use the Get-MgBetaBetaShareDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Files

Get-MgBetaShareDriveItem -SharedDriveItemId $sharedDriveItemId -ExpandProperty "children"
```
This example shows how to use the Get-MgBetaBetaShareDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

