### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	PhoneNumber = "+1 2065555554"
	PhoneType = "mobile"
}
# A UPN can also be used as -UserId.
Update-MgUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId -BodyParameter $params
```
