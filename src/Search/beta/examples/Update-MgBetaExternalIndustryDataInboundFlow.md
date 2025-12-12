### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	"@odata.type" = "#microsoft.graph.industryData.inboundApiFlow"
	displayName = "Updated flow name"
}

Update-MgBetaExternalIndustryDataInboundFlow -InboundFlowId $inboundFlowId -BodyParameter $params

```
This example shows how to use the Update-MgBetaExternalIndustryDataInboundFlow Cmdlet.

