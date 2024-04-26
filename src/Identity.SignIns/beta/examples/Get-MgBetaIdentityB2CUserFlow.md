### Example 1: List all b2cIdentityUserFlow objects

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2CUserFlow

```
This example will list all b2cidentityuserflow objects

### Example 2: List all b2cIdentityUserFlow objects and expand identityProviders

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2CUserFlow -ExpandProperty "identityProviders" 

```
This example will list all b2cidentityuserflow objects and expand identityproviders

