### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	phoneNumber = "+1 2065555555"
	phoneType = "mobile"
}

# A UPN can also be used as -UserId.
New-MgUserAuthenticationPhoneMethod -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserAuthenticationPhoneMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

