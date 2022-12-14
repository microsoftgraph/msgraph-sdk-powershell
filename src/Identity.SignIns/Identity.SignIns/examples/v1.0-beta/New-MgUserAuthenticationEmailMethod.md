### Example 1: Using the New-MgBetaUserAuthenticationEmailMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	EmailAddress = "kim@contoso.com"
}
New-MgBetaUserAuthenticationEmailMethod -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserAuthenticationEmailMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
