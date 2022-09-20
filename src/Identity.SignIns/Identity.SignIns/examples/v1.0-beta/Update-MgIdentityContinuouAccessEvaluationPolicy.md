### Example 1: Using the Update-MgIdentityContinuouAccessEvaluationPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.continuousAccessEvaluationPolicy"
	Migrate = $true
}
Update-MgIdentityContinuouAccessEvaluationPolicy -BodyParameter $params
```
This example shows how to use the Update-MgIdentityContinuouAccessEvaluationPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
