### Example 1: Using the Get-MgIdentityB2XUserFlowUserAttributeAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId
```
This example shows how to use the Get-MgIdentityB2XUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgIdentityB2XUserFlowUserAttributeAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -ExpandProperty "userAttribute" 
```
This example shows how to use the Get-MgIdentityB2XUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
