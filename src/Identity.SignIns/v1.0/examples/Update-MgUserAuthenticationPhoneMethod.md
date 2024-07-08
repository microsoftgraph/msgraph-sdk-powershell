### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	phoneNumber = "+1 2065555554"
	phoneType = "mobile"
}

Update-MgUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId -BodyParameter $params
```
This example shows how to use the Update-MgUserAuthenticationPhoneMethod Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

