### Example 1
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Roles = @(
		"read"
	)
}
Update-MgSitePermission -SiteId $siteId -PermissionId $permissionId -BodyParameter $params
```
