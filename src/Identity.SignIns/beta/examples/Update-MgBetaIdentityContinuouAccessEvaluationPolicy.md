### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.continuousAccessEvaluationPolicy"
	migrate = $true
}

Update-MgBetaIdentityContinuouAccessEvaluationPolicy -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityContinuouAccessEvaluationPolicy Cmdlet.

