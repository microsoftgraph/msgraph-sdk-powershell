### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	device = @{
		id = "aad49556-####-####-####-############"
	}
	verificationCode = "588651"
	displayName = "Amy Masters Token"
}

# A UPN can also be used as -UserId.
Set-MgBetaUserAuthenticationHardwareOathMethodAndActivate -UserId $userId -BodyParameter $params

```
This example shows how to use the Set-MgBetaUserAuthenticationHardwareOathMethodAndActivate Cmdlet.

