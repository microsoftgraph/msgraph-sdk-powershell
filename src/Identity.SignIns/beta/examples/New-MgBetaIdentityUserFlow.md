### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	id = "Pol1"
	userFlowType = "signUpOrSignIn"
	userFlowTypeVersion = 1
}

New-MgBetaIdentityUserFlow -BodyParameter $params

```
This example shows how to use the New-MgBetaIdentityUserFlow Cmdlet.

