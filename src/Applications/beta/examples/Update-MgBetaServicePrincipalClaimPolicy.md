### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	"@odata.type" = "#microsoft.graph.customClaimsPolicy"
	includeBasicClaimSet = "Boolean"
	includeApplicationIdInIssuer = "Boolean"
	audienceOverride = "String"
	claims = @(
		@{
			"@odata.type" = "microsoft.graph.customClaim"
		}
	)
}

Update-MgBetaServicePrincipalClaimPolicy -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the Update-MgBetaServicePrincipalClaimPolicy Cmdlet.

