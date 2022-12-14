### Example 1: Using the New-MgBetaSitePermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
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
New-MgBetaSitePermission -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgBetaSitePermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
