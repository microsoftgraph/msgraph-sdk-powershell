### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	grantees = @(
		@{
			email = "ryan@contoso.com"
		}
	)
}

Revoke-MgBetaDriveItemPermissionGrant -DriveId $driveId -DriveItemId $driveItemId -PermissionId $permissionId -BodyParameter $params

```
This example shows how to use the Revoke-MgBetaDriveItemPermissionGrant Cmdlet.

