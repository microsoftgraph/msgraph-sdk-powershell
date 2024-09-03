### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	"@odata.type" = "microsoft.graph.industryData.oneRosterApiDataConnector"
	displayName = "One Roster Connector"
}

Update-MgBetaExternalIndustryDataConnector -IndustryDataConnectorId $industryDataConnectorId -BodyParameter $params

```
This example shows how to use the Update-MgBetaExternalIndustryDataConnector Cmdlet.

