### Example 1: Get a user's system-preferred MFA method

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaUserAuthenticationSignInPreference -UserId $userId

```
This example will get a user's system-preferred mfa method

