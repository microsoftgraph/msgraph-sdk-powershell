### Example 1: Using the New-MgSitePermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Roles = @(
		"write"
	)
	GrantedToIdentities = @(
		@{
			Application = @{
				Id = "89ea5c94-7736-4e25-95ad-3fa95f62b66e"
				DisplayName = "Contoso Time Manager App"
			}
		}
	)
}
New-MgSitePermission -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgSitePermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
