###Example 1
```
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
