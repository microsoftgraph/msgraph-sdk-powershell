### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	"@odata.type" = "#microsoft.graph.industryData.inboundFileFlow"
	"dataConnector@odata.bind" = "https://graph.microsoft.com/beta/external/industryData/dataConnectors/51dca0a0-85f6-4478-f526-08daddab2271"
	dataDomain = "educationRostering"
	displayName = "Inbound rostering flow"
	effectiveDateTime = [System.DateTime]::Parse("2023-03-12T16:40:46.924769+05:30")
	expirationDateTime = [System.DateTime]::Parse("2023-03-13T16:40:46.924769+05:30")
	"year@odata.bind" = "https://graph.microsoft.com/beta/external/industryData/years/ebf18762-ab92-487e-21d1-08daddab28bb"
}

New-MgBetaExternalIndustryDataInboundFlow -BodyParameter $params

```
This example shows how to use the New-MgBetaExternalIndustryDataInboundFlow Cmdlet.

