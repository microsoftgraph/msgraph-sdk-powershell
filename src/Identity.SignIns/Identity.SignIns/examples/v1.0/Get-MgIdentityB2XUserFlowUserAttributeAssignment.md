### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -ExpandProperty "userAttribute" 
```
### Example 4
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId -ExpandProperty "userAttribute" 
```
