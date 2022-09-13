###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	EmailAddress = "kim@contoso.com"
}
New-MgUserAuthenticationEmailMethod -UserId $userId -BodyParameter $params
```
