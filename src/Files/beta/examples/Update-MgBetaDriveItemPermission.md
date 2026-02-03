### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Files

$params = @{
	roles = @(
		"read"
	)
}

Update-MgBetaDriveItemPermission -DriveId $driveId -DriveItemId $driveItemId -PermissionId $permissionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDriveItemPermission Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

