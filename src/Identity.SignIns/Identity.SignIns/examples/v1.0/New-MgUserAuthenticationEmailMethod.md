### Example 1: Using the New-MgUserAuthenticationEmailMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	EmailAddress = "kim@contoso.com"
}
New-MgUserAuthenticationEmailMethod -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserAuthenticationEmailMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
