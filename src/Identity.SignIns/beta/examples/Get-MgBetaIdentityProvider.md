### Example 1: List all identity provider resources configured in an Azure AD tenant

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityProvider

```
This example will list all identity provider resources configured in an azure ad tenant

### Example 2: List all **identityProvider** configured in an Azure AD B2C tenant

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityProvider

```
This example will list all **identityprovider** configured in an azure ad b2c tenant

