### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.authorityTemplate"
	displayName = "Business"
}

New-MgSecurityLabelAuthority -BodyParameter $params

```
This example shows how to use the New-MgSecurityLabelAuthority Cmdlet.

