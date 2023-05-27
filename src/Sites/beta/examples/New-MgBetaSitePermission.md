### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Sites

$params = @{
	roles = @(
		"write"
	)
	grantedToIdentities = @(
		@{
			application = @{
				id = "89ea5c94-7736-4e25-95ad-3fa95f62b66e"
				displayName = "Contoso Time Manager App"
			}
		}
	)
}

New-MgBetaSitePermission -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaSitePermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

