### Example 1: Using the Grant-MgSharePermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Files
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
Grant-MgSharePermission -SharedDriveItemId $sharedDriveItemId -BodyParameter $params
```
This example shows how to use the Grant-MgSharePermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
