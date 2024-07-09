### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	userPreferredMethodForSecondaryAuthentication = "oath"
}

Update-MgBetaUserAuthenticationSignInPreference -UserId $userId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserAuthenticationSignInPreference Cmdlet.

