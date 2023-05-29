### Example 1: Get a bundle and its children in a single call

```powershell
Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveItem -DriveId $driveId -DriveItemId $driveItemId -ExpandProperty "children"
```
This example shows how to use the Get-MgBetaDriveItem Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

