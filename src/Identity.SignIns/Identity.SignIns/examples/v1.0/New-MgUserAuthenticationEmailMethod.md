### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	EmailAddress = "kim@contoso.com"
}
New-MgUserAuthenticationEmailMethod -UserId $userId -BodyParameter $params
```
