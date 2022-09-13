###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -ExpandProperty "userAttribute" 
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId -ExpandProperty "userAttribute" 
```
