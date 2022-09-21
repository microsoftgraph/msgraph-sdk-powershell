### Example 1: Using the Update-MgSiteTermStoreSetTerm Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Labels = @(
		@{
			Name = "changedLabel"
			LanguageTag = "en-US"
			IsDefault = $true
		}
	)
}
Update-MgSiteTermStoreSetTerm -SiteId $siteId -SetId $setId -TermId $termId -BodyParameter $params
```
This example shows how to use the Update-MgSiteTermStoreSetTerm Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
