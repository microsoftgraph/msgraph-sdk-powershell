### Example 1: Using the Invoke-MgBetaDismissRiskyServicePrincipal Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	ServicePrincipalIds = @(
		"9089a539-a539-9089-39a5-899039a58990"
	)
}
Invoke-MgBetaDismissRiskyServicePrincipal -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaDismissRiskyServicePrincipal Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
