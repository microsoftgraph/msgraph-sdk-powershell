### Example 1: Using the Update-MgBetaSitePermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	Roles = @(
		"read"
	)
}
Update-MgBetaSitePermission -SiteId $siteId -PermissionId $permissionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSitePermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
