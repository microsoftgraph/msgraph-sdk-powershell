### Example 1: Using the Grant-MgBetaSharePermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Files
$params = @{
	Recipients = @(
		@{
			Email = "john@contoso.com"
		}
		@{
			Email = "ryan@external.com"
		}
	)
	Roles = @(
		"read"
	)
}
Grant-MgBetaSharePermission -SharedDriveItemId $sharedDriveItemId -BodyParameter $params
```
This example shows how to use the Grant-MgBetaSharePermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
