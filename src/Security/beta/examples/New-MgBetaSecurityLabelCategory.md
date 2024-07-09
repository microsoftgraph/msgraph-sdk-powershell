### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.categoryTemplate"
	displayName = "Accounts Payable"
}

New-MgBetaSecurityLabelCategory -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityLabelCategory Cmdlet.

