### Example 1: Update a user's system-preferred MFA method

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	userPreferredMethodForSecondaryAuthentication = "oath"
}

Update-MgBetaUserAuthenticationSignInPreference -UserId $userId -BodyParameter $params

```
This example will update a user's system-preferred mfa method

