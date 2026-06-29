### Example 1: Create a user flow with the default values

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	id = "Partner"
	userFlowType = "signUpOrSignIn"
	userFlowTypeVersion = 1
}

New-MgBetaIdentityB2XUserFlow -BodyParameter $params

```
This example will create a user flow with the default values

### Example 2: Create a user flow with the default values and an identity provider

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	id = "Partner"
	userFlowType = "signUpOrSignIn"
	userFlowTypeVersion = 1
	identityProviders = @(
		@{
			id = "Facebook-OAuth"
			type = "Facebook"
			name = "Facebook"
		}
	)
}

New-MgBetaIdentityB2XUserFlow -BodyParameter $params

```
This example will create a user flow with the default values and an identity provider

### Example 3: Create a user flow with the default values and configuration for API connectors

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	id = "UserFlowWithAPIConnector"
	userFlowType = "signUpOrSignIn"
	userFlowTypeVersion = 1
	apiConnectorConfiguration = @{
		postFederationSignup = @{
			"@odata.id" = '{apiConnectorId}'
		}
		postAttributeCollection = @{
			"@odata.id" = '{apiConnectorId}'
		}
	}
}

New-MgBetaIdentityB2XUserFlow -BodyParameter $params

```
This example will create a user flow with the default values and configuration for api connectors

