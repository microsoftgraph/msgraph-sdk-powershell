### Example 1: Get the details of an identityUserFlowAttributeAssignment

```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId
```
This example shows how to use the Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the details of an identityUserFlowAttributeAssignment and expand userAttribute

```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId -ExpandProperty "userAttribute"
```
This example shows how to use the Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

