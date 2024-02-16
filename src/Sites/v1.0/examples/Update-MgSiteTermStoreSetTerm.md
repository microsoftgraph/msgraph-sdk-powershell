### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Sites

$params = @{
	labels = @(
		@{
			name = "changedLabel"
			languageTag = "en-US"
			isDefault = $true
		}
	)
}

Update-MgSiteTermStoreSetTerm -SiteId $siteId -SetId $setId -TermId $termId -BodyParameter $params

```
This example shows how to use the Update-MgSiteTermStoreSetTerm Cmdlet.

