### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	servicePrincipalIds = @(
	"9089a539-a539-9089-39a5-899039a58990"
)
}

Confirm-MgBetaRiskyServicePrincipalCompromised -BodyParameter $params

```
This example shows how to use the Confirm-MgBetaRiskyServicePrincipalCompromised Cmdlet.

