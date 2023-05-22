### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	phoneNumber = "+1 2065555555"
	phoneType = "mobile"
}

# A UPN can also be used as -UserId.
New-MgBetaUserAuthenticationPhoneMethod -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaUserAuthenticationPhoneMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

