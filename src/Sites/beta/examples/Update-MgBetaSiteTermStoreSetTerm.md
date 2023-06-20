### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Sites

$params = @{
	labels = @(
		@{
			name = "changedLabel"
			languageTag = "en-US"
			isDefault = $true
		}
	)
}

Update-MgBetaSiteTermStoreSetTerm -SiteId $siteId -SetId $setId -TermId $termId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSiteTermStoreSetTerm Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

