### Example 1: Using the New-MgIdentityB2CUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
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
New-MgIdentityB2CUserFlow -BodyParameter $params
```
This example shows how to use the New-MgIdentityB2CUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgIdentityB2CUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "Customer"
	UserFlowType = "signUpOrSignIn"
	UserFlowTypeVersion = 3
	IdentityProviders = @(
		@{
			Id = "Facebook-OAuth"
		}
	)
}
New-MgIdentityB2CUserFlow -BodyParameter $params
```
This example shows how to use the New-MgIdentityB2CUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgIdentityB2CUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "Customer"
	UserFlowType = "signUpOrSignIn"
	UserFlowTypeVersion = 3
}
New-MgIdentityB2CUserFlow -BodyParameter $params
```
This example shows how to use the New-MgIdentityB2CUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
