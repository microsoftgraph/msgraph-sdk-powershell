### Example 1: Using the Invoke-MgBetaQuerySearch Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	Requests = @(
		@{
			EntityTypes = @(
				"externalItem"
			)
			ContentSources = @(
				"/external/connections/connectionfriendlyname"
			)
			Query = @{
				QueryString = "contoso product"
			}
			From = 0
			Size = 25
			Fields = @(
				"title"
				"description"
			)
		}
	)
}
Invoke-MgBetaQuerySearch -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaQuerySearch Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
