### Example 1: Update a user's MFA state

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	perUserMfaState = "disabled"
}

Update-MgBetaUserAuthenticationRequirement -UserId $userId -BodyParameter $params

```
This example will update a user's mfa state

