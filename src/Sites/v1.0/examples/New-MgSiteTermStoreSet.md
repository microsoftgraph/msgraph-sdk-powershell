### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Sites

$params = @{
	"@odata.type" = "#microsoft.graph.termStore.set"
	parentGroup = @{
		id = "fc733b51-10f1-40fd-b784-dc6d1e42804b"
	}
	localizedNames = @(
		@{
			languageTag = "en-US"
			name = "Department"
		}
	)
}

New-MgSiteTermStoreSet -SiteId $siteId -BodyParameter $params

```
This example shows how to use the New-MgSiteTermStoreSet Cmdlet.

