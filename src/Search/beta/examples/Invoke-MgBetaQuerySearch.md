### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	requests = @(
		@{
			entityTypes = @(
				"externalItem"
			)
			contentSources = @(
				"/external/connections/connectionfriendlyname"
			)
			query = @{
				queryString = "contoso product"
			}
			from = 0
			size = 25
			fields = @(
				"title"
				"description"
			)
		}
	)
}

Invoke-MgBetaQuerySearch -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaQuerySearch Cmdlet.

