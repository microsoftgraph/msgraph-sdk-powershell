### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	roles = @(
		"read"
	)
}

Update-MgSitePermission -SiteId $siteId -PermissionId $permissionId -BodyParameter $params
```
This example shows how to use the Remove-MgSitePermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

