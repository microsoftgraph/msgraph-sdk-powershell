### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	"@odata.type" = "microsoft.graph.industryData.azureDataLakeConnector"
	displayName = "CSV files from SIS"
}

Update-MgBetaExternalIndustryDataConnector -IndustryDataConnectorId $industryDataConnectorId -BodyParameter $params

```
This example shows how to use the Update-MgBetaExternalIndustryDataConnector Cmdlet.

