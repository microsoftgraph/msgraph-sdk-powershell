### Example 1: Using the Invoke-MgDismissRiskyServicePrincipal Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	ServicePrincipalIds = @(
		"9089a539-a539-9089-39a5-899039a58990"
	)
}
Invoke-MgDismissRiskyServicePrincipal -BodyParameter $params
```
This example shows how to use the Invoke-MgDismissRiskyServicePrincipal Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
