### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.authorityTemplate"
	displayName = "Business"
}

New-MgBetaSecurityLabelAuthority -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityLabelAuthority Cmdlet.

