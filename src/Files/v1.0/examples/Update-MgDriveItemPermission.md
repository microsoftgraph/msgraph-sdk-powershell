### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Files

$params = @{
	roles = @(
		"read"
	)
}

Update-MgDriveItemPermission -DriveId $driveId -DriveItemId $driveItemId -PermissionId $permissionId -BodyParameter $params
```
This example shows how to use the Update-MgDriveItemPermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

