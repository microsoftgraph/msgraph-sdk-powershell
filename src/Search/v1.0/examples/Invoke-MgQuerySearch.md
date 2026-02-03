### Example 1: Basic call to perform a search request

```powershell

Import-Module Microsoft.Graph.Search

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

Invoke-MgQuerySearch -BodyParameter $params

```
This example will basic call to perform a search request

### Example 2: Basic call to use queryTemplate

```powershell

Import-Module Microsoft.Graph.Search

$params = @{
	requests = @(
		@{
			entityTypes = @(
				"listItem"
			)
			query = @{
				queryString = "contoso"
				queryTemplate = '{searchTerms} CreatedBy:Bob"
			}
			from = 0
			size = 25
		}
	)
}

Invoke-MgQuerySearch -BodyParameter $params

```
This example will basic call to use querytemplate

