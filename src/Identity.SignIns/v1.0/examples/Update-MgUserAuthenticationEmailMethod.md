### Example 1: Using the Update-MgUserAuthenticationEmailMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	EmailAddress = "kim@contoso.com"
}
Update-MgUserAuthenticationEmailMethod -UserId $userId -EmailAuthenticationMethodId $emailAuthenticationMethodId -BodyParameter $params
```
This example shows how to use the Update-MgUserAuthenticationEmailMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
