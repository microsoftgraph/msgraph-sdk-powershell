### Example 1: Create a specific **social identity provider** (Microsoft Entra ID and Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "microsoft.graph.socialIdentityProvider"
	displayName = "Login with Amazon"
	identityProviderType = "Amazon"
	clientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	clientSecret = "000000000000"
}

New-MgBetaIdentityProvider -BodyParameter $params

```
This example will create a specific **social identity provider** (microsoft entra id and azure ad b2c)

### Example 2: Create a specific **OpenID Connect identity provider** (only for Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "microsoft.graph.openIdConnectIdentityProvider"
	displayName = "Login with the Contoso identity provider"
	clientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	clientSecret = "12345"
	claimsMapping = @{
		userId = "myUserId"
		givenName = "myGivenName"
		surname = "mySurname"
		email = "myEmail"
		displayName = "myDisplayName"
	}
	domainHint = "mycustomoidc"
	metadataUrl = "https://mycustomoidc.com/.well-known/openid-configuration"
	responseMode = "form_post"
	responseType = "code"
	scope = "openid"
}

New-MgBetaIdentityProvider -BodyParameter $params

```
This example will create a specific **openid connect identity provider** (only for azure ad b2c)

### Example 3: Retrieves Apple identity provider (only for Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "microsoft.graph.appleManagedIdentityProvider"
	displayName = "Sign in with Apple"
	developerId = "UBF8T346G9"
	serviceId = "com.microsoft.rts.b2c.test.client"
	keyId = "99P6D879C4"
	certificateData = "******"
}

New-MgBetaIdentityProvider -BodyParameter $params

```
This example retrieves apple identity provider (only for azure ad b2c)

