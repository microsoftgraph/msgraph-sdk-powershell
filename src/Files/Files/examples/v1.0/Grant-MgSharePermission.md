### Example 1
``` powershell
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
