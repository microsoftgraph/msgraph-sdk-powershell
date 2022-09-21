### Example 1: Using the Update-MgSitePermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Roles = @(
		"read"
	)
}
Update-MgSitePermission -SiteId $siteId -PermissionId $permissionId -BodyParameter $params
```
This example shows how to use the Update-MgSitePermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
