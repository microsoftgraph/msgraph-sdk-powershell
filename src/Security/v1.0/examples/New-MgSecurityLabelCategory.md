### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.categoryTemplate"
	displayName = "Accounts Payable"
}

New-MgSecurityLabelCategory -BodyParameter $params

```
This example shows how to use the New-MgSecurityLabelCategory Cmdlet.

