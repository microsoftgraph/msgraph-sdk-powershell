### Example 1: Update a specific **social identity provider** (Microsoft Entra ID or Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	clientSecret = "1111111111111"
}

Update-MgBetaIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params

```
This example will update a specific **social identity provider** (microsoft entra id or azure ad b2c)

### Example 2: Update a specific **OpenID Connect identity provider** (only for Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	responseType = "id_token"
}

Update-MgBetaIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params

```
This example will update a specific **openid connect identity provider** (only for azure ad b2c)

### Example 3: Update a specific **Apple identity provider** (only for Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	displayName = "Apple"
}

Update-MgBetaIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params

```
This example will update a specific **apple identity provider** (only for azure ad b2c)

