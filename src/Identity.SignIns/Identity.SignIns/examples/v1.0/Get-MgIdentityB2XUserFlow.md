### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlow -B2xIdentityUserFlowId $b2xIdentityUserFlowId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlow -ExpandProperty "identityProviders" 
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlow
```
