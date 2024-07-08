### Example 1: Create a user

```powershell

Import-Module Microsoft.Graph.Beta.Users

$params = @{
	accountEnabled = $true
	displayName = "Adele Vance"
	mailNickname = "AdeleV"
	userPrincipalName = "AdeleV@contoso.com"
	passwordProfile = @{
		forceChangePasswordNextSignIn = $true
		password = "xWwvJ]6NMw+bWH-d"
	}
}

New-MgBetaUser -BodyParameter $params

```
This example will create a user

### Example 2: Create a user with social and local account identities

```powershell

Import-Module Microsoft.Graph.Beta.Users

$params = @{
	displayName = "John Smith"
	identities = @(
		@{
			signInType = "userName"
			issuer = "contoso.com"
			issuerAssignedId = "johnsmith"
		}
		@{
			signInType = "emailAddress"
			issuer = "contoso.com"
			issuerAssignedId = "jsmith@yahoo.com"
		}
		@{
			signInType = "federated"
			issuer = "facebook.com"
			issuerAssignedId = "5eecb0cd"
		}
	)
	passwordProfile = @{
		password = "password-value"
		forceChangePasswordNextSignIn = $false
	}
	passwordPolicies = "DisablePasswordExpiration"
}

New-MgBetaUser -BodyParameter $params

```
This example will create a user with social and local account identities

