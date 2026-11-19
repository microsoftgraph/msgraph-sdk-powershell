### Example 1: Get a user's MFA state

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaUserAuthenticationRequirement -UserId $userId

```
This example will get a user's mfa state

