### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	phoneNumber = "+1 2065555554"
	phoneType = "mobile"
}

Update-MgBetaUserAuthenticationPhoneMethod -UserId $userId -PhoneAuthenticationMethodId $phoneAuthenticationMethodId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserAuthenticationPhoneMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

