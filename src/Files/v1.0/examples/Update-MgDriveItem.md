### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Files

$params = @{
	parentReference = @{
		id = '{new-parent-folder-id}'
	}
	name = "new-item-name.txt"
}

Update-MgDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params
```
This example shows how to use the Update-MgDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

