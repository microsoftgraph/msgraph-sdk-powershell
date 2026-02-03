### Example 1: Update a specific **social identity provider** (Microsoft Entra ID or Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	clientSecret = "1111111111111"
}

Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params

```
This example will update a specific **social identity provider** (microsoft entra id or azure ad b2c)

### Example 2: Update a specific **Apple identity provider** (only for Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	displayName = "Apple"
}

Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params

```
This example will update a specific **apple identity provider** (only for azure ad b2c)

