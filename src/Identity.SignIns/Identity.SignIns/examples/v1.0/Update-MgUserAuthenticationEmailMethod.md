###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	EmailAddress = "kim@contoso.com"
}
Update-MgUserAuthenticationEmailMethod -UserId $userId -EmailAuthenticationMethodId $emailAuthenticationMethodId -BodyParameter $params
```
