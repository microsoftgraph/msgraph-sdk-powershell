### Example 1: Using the Update-MgUserAuthenticationPhoneMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	PhoneNumber = "+1 2065555554"
	PhoneType = "mobile"
}
# A UPN can also be used as -UserId.
Update-MgUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId -BodyParameter $params
```
This example shows how to use the Update-MgUserAuthenticationPhoneMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
