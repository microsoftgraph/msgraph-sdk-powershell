### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	labels = @(
		@{
			languageTag = "en-US"
			name = "Car"
			isDefault = $true
		}
	)
}

New-MgSiteTermStoreSetChild -SiteId $siteId -SetId $setId -BodyParameter $params
```
This example shows how to use the New-MgSiteTermStoreGroupSetChild Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

