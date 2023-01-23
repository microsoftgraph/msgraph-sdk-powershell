### Example 1: Using the New-MgBetaUserAuthenticationPhoneMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	PhoneNumber = "+1 2065555555"
	PhoneType = "mobile"
}
# A UPN can also be used as -UserId.
New-MgBetaUserAuthenticationPhoneMethod -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserAuthenticationPhoneMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
