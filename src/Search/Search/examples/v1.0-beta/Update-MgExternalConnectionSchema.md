### Example 1: Using the Update-MgExternalConnectionSchema Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	BaseType = "microsoft.graph.externalItem"
	Properties = @(
		@{
			Name = "ticketTitle"
			Type = "string"
			IsSearchable = "true"
			IsRetrievable = "true"
			Labels = @(
				"title"
			)
		}
		@{
			Name = "priority"
			Type = "string"
			IsQueryable = "true"
			IsRetrievable = "true"
			IsSearchable = "false"
		}
		@{
			Name = "assignee"
			Type = "string"
			IsRetrievable = "true"
		}
	)
}
Update-MgExternalConnectionSchema -ExternalConnectionId $externalConnectionId -BodyParameter $params
```
This example shows how to use the Update-MgExternalConnectionSchema Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
