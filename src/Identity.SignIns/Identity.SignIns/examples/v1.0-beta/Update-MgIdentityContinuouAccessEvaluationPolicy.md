### Example 1: Using the Update-MgBetaIdentityContinuouAccessEvaluationPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.continuousAccessEvaluationPolicy"
	Migrate = $true
}
Update-MgBetaIdentityContinuouAccessEvaluationPolicy -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityContinuouAccessEvaluationPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
