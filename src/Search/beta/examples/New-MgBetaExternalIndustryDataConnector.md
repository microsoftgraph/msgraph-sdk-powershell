### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	"@odata.type" = "#microsoft.graph.industryData.azureDataLakeConnector"
	displayName = "CSV connector"
	"sourceSystem@odata.bind" = "https://graph.microsoft.com/beta/external/industryData/sourceSystems('aa050107-5784-4a8e-1876-08daddab21bc')"
	fileFormat = @{
		"@odata.type" = "microsoft.graph.industryData.fileFormatReferenceValue"
		code = "schoolDataSyncV1"
	}
}

New-MgBetaExternalIndustryDataConnector -BodyParameter $params

```
This example shows how to use the New-MgBetaExternalIndustryDataConnector Cmdlet.

