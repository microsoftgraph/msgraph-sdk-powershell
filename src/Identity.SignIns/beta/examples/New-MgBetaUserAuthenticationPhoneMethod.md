### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	phoneNumber = "+1 2065555555"
	phoneType = "mobile"
}

New-MgBetaUserAuthenticationPhoneMethod -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserAuthenticationPhoneMethod Cmdlet.

