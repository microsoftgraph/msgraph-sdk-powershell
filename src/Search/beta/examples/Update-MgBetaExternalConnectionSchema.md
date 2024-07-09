### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	baseType = "microsoft.graph.externalItem"
	properties = @(
		@{
			name = "ticketTitle"
			type = "string"
			isSearchable = "true"
			isRetrievable = "true"
			labels = @(
			"title"
		)
	}
	@{
		name = "priority"
		type = "string"
		isQueryable = "true"
		isRetrievable = "true"
		isSearchable = "false"
	}
	@{
		name = "assignee"
		type = "string"
		isRetrievable = "true"
	}
)
}

Update-MgBetaExternalConnectionSchema -ExternalConnectionId $externalConnectionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaExternalConnectionSchema Cmdlet.

