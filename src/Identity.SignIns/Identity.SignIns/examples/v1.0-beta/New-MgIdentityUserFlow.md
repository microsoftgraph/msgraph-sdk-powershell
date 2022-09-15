### Example 1: Using the New-MgIdentityUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "Pol1"
	UserFlowType = "signUpOrSignIn"
	UserFlowTypeVersion = 1
}
New-MgIdentityUserFlow -BodyParameter $params
```
This example shows how to use the New-MgIdentityUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
