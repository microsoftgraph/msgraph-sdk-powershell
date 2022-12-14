### Example 1: Using the Update-MgBetaUserAuthenticationEmailMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	EmailAddress = "kim@contoso.com"
}
Update-MgBetaUserAuthenticationEmailMethod -UserId $userId -EmailAuthenticationMethodId $emailAuthenticationMethodId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserAuthenticationEmailMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
