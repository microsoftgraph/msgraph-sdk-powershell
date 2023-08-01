### Example 1: Retrieve a specific social identity provider (Azure AD or Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId

```
This example will retrieve a specific social identity provider (azure ad or azure ad b2c)

### Example 2: Retrieve a specific built-in identity provider (only for Azure AD)

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId

```
This example will retrieve a specific built-in identity provider (only for azure ad)

### Example 3: Retrieves Apple identity provider(only for Azure AD B2C)

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId

```
This example retrieves apple identity provider(only for azure ad b2c)

