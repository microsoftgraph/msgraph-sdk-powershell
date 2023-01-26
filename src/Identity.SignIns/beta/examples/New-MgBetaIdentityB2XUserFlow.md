### Example 1: Using the New-MgBetaIdentityB2XUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Id = "UserFlowWithAPIConnector"
	UserFlowType = "signUpOrSignIn"
	UserFlowTypeVersion = 1
	ApiConnectorConfiguration = @{
		PostFederationSignup = @{
			"@odata.id" = "{apiConnectorId}"
		}
		PostAttributeCollection = @{
			"@odata.id" = "{apiConnectorId}"
		}
	}
}
New-MgBetaIdentityB2XUserFlow -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityB2XUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaIdentityB2XUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Id = "Partner"
	UserFlowType = "signUpOrSignIn"
	UserFlowTypeVersion = 1
	IdentityProviders = @(
		@{
			Id = "Facebook-OAuth"
			Type = "Facebook"
			Name = "Facebook"
		}
	)
}
New-MgBetaIdentityB2XUserFlow -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityB2XUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaIdentityB2XUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Id = "Partner"
	UserFlowType = "signUpOrSignIn"
	UserFlowTypeVersion = 1
}
New-MgBetaIdentityB2XUserFlow -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityB2XUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
