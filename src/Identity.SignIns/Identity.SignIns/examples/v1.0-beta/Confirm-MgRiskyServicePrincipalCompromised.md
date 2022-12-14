### Example 1: Using the Confirm-MgBetaRiskyServicePrincipalCompromised Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	ServicePrincipalIds = @(
		"9089a539-a539-9089-39a5-899039a58990"
	)
}
Confirm-MgBetaRiskyServicePrincipalCompromised -BodyParameter $params
```
This example shows how to use the Confirm-MgBetaRiskyServicePrincipalCompromised Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
