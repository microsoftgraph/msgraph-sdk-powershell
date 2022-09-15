### Example 1: Using the Invoke-MgQuerySearch Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
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
Invoke-MgQuerySearch -BodyParameter $params
```
This example shows how to use the Invoke-MgQuerySearch Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
