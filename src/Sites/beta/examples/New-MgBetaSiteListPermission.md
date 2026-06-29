### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	grantedToV2 = @{
		application = @{
			id = "89ea5c94-7736-4e25-95ad-3fa95f62b66e"
			displayName = "Contoso Time Manager App"
		}
	}
	roles = @(
	"write"
)
}

New-MgBetaSiteListPermission -SiteId $siteId -ListId $listId -BodyParameter $params

```
This example shows how to use the New-MgBetaSiteListPermission Cmdlet.

