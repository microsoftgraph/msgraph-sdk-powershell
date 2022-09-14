### Example 1
``` powershell
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
