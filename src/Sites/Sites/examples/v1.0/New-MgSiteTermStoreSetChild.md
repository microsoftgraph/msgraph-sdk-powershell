### Example 1: Using the New-MgSiteTermStoreSetChild Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Labels = @(
		@{
			LanguageTag = "en-US"
			Name = "Car"
			IsDefault = $true
		}
	)
}
New-MgSiteTermStoreSetChild -SiteId $siteId -SetId $setId -BodyParameter $params
```
This example shows how to use the New-MgSiteTermStoreSetChild Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
