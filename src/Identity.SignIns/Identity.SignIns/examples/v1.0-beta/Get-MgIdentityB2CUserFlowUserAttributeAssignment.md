### Example 1: Using the Get-MgIdentityB2CUserFlowUserAttributeAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlowUserAttributeAssignment -B2cIdentityUserFlowId $b2cIdentityUserFlowId
```
This example shows how to use the Get-MgIdentityB2CUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgIdentityB2CUserFlowUserAttributeAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlowUserAttributeAssignment -B2cIdentityUserFlowId $b2cIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId
```
This example shows how to use the Get-MgIdentityB2CUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgIdentityB2CUserFlowUserAttributeAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlowUserAttributeAssignment -B2cIdentityUserFlowId $b2cIdentityUserFlowId -ExpandProperty "userAttribute" 
```
This example shows how to use the Get-MgIdentityB2CUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgIdentityB2CUserFlowUserAttributeAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlowUserAttributeAssignment -B2cIdentityUserFlowId $b2cIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId -ExpandProperty "userAttribute" 
```
This example shows how to use the Get-MgIdentityB2CUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
