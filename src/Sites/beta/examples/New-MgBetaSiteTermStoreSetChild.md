### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Sites

$params = @{
	labels = @(
		@{
			languageTag = "en-US"
			name = "Car"
			isDefault = $true
		}
	)
}

New-MgBetaSiteTermStoreSetChild -SiteId $siteId -SetId $setId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteTermStoreSetChild Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

