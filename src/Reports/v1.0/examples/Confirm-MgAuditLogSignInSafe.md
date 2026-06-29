### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Reports

$params = @{
	requestIds = @(
	"29f270bb-4d23-4f68-8a57-dc73dc0d4caf"
"20f91ec9-d140-4d90-9cd9-f618587a1471"
)
}

Confirm-MgAuditLogSignInSafe -BodyParameter $params

```
This example shows how to use the Confirm-MgAuditLogSignInSafe Cmdlet.

