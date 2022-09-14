### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "UserFlowWithAPIConnector"
	UserFlowType = "signUpOrSignIn"
	UserFlowTypeVersion = 1
	ApiConnectorConfiguration = @{
		PostFederationSignup = @{
			"@odata.id" = "https://graph.microsoft.com/v1/identity/apiConnectors/{id}"
		}
		PostAttributeCollection = @{
			"@odata.id" = "https://graph.microsoft.com/v1/identity/apiConnectors/{id}"
		}
	}
}
New-MgIdentityB2XUserFlow -BodyParameter $params
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
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
New-MgIdentityB2XUserFlow -BodyParameter $params
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "Partner"
	UserFlowType = "signUpOrSignIn"
	UserFlowTypeVersion = 1
}
New-MgIdentityB2XUserFlow -BodyParameter $params
```
