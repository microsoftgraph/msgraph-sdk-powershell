### Example 1: List all b2xIdentityUserFlow objects

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2XUserFlow

```
This example will list all b2xidentityuserflow objects

### Example 2: List all b2xIdentityUserFlow objects and expand identityProviders

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2XUserFlow -ExpandProperty "identityProviders" 

```
This example will list all b2xidentityuserflow objects and expand identityproviders

