###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlow -B2xIdentityUserFlowId $b2xIdentityUserFlowId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlow -ExpandProperty "identityProviders" 
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlow
```
