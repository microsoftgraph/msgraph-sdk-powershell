### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	verificationCode = "588651"
	displayName = "Amy Masters Token"
}

# A UPN can also be used as -UserId.
Initialize-MgBetaUserAuthenticationHardwareOathMethod -UserId $userId -HardwareOathAuthenticationMethodId $hardwareOathAuthenticationMethodId -BodyParameter $params

```
This example shows how to use the Initialize-MgBetaUserAuthenticationHardwareOathMethod Cmdlet.

