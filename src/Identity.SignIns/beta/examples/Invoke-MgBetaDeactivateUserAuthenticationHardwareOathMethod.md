### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

# A UPN can also be used as -UserId.
Invoke-MgBetaDeactivateUserAuthenticationHardwareOathMethod -UserId $userId -HardwareOathAuthenticationMethodId $hardwareOathAuthenticationMethodId

```
This example shows how to use the Invoke-MgBetaDeactivateUserAuthenticationHardwareOathMethod Cmdlet.

