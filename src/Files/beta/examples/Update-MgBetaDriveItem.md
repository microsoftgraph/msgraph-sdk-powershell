### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

$params = @{
	parentReference = @{
		id = "new-parent-folder-id"
	}
	name = "new-item-name.txt"
}

Update-MgBetaDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDriveItem Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

