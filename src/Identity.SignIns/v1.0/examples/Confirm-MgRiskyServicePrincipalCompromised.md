### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	servicePrincipalIds = @(
	"9089a539-a539-9089-39a5-899039a58990"
)
}

Confirm-MgRiskyServicePrincipalCompromised -BodyParameter $params

```
This example shows how to use the Confirm-MgRiskyServicePrincipalCompromised Cmdlet.

