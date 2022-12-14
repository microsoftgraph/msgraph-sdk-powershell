### Example 1: Using the Update-MgBetaUserAuthenticationPhoneMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	PhoneNumber = "+1 2065555554"
	PhoneType = "mobile"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserAuthenticationPhoneMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
