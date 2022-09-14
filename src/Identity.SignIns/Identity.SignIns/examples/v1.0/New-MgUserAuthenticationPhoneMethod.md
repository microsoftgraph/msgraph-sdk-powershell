### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	PhoneNumber = "+1 2065555555"
	PhoneType = "mobile"
}
# A UPN can also be used as -UserId.
New-MgUserAuthenticationPhoneMethod -UserId $userId -BodyParameter $params
```
