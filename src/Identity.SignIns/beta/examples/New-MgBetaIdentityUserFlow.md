### Example 1: Using the New-MgBetaIdentityUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Id = "Pol1"
	UserFlowType = "signUpOrSignIn"
	UserFlowTypeVersion = 1
}
New-MgBetaIdentityUserFlow -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
