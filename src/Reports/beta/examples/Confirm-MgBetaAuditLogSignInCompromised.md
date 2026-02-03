### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Reports

$params = @{
	requestIds = @(
	"f01c6af6-6683-4a37-a945-0a925501eede"
"42bf60ac-d0cb-4206-aa5c-101884298f55"
"f09c8f14-8d8e-42cf-8a7e-732b0594e79b"
)
}

Confirm-MgBetaAuditLogSignInCompromised -BodyParameter $params

```
This example shows how to use the Confirm-MgBetaAuditLogSignInCompromised Cmdlet.

