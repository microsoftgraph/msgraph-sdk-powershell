### Example 1: List all b2xIdentityUserFlow objects

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityB2XUserFlow

```
This example will list all b2xidentityuserflow objects

### Example 2: List all b2xIdentityUserFlow objects and expand identityProviders

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityB2XUserFlow -ExpandProperty "identityProviders" 

```
This example will list all b2xidentityuserflow objects and expand identityproviders

