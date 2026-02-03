### Example 1: Create a specific social identity provider (Microsoft Entra ID and Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "microsoft.graph.socialIdentityProvider"
	displayName = "Login with Amazon"
	identityProviderType = "Amazon"
	clientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	clientSecret = "000000000000"
}

New-MgIdentityProvider -BodyParameter $params

```
This example will create a specific social identity provider (microsoft entra id and azure ad b2c)

### Example 2: Create Apple identity provider (only for Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "microsoft.graph.appleManagedIdentityProvider"
	displayName = "Sign in with Apple"
	developerId = "UBF8T346G9"
	serviceId = "com.microsoft.rts.b2c.test.client"
	keyId = "99P6D879C4"
	certificateData = "******"
}

New-MgIdentityProvider -BodyParameter $params

```
This example will create apple identity provider (only for azure ad b2c)

