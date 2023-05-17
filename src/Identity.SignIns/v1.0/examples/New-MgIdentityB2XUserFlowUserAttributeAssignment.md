### Example 1: List userAttributeAssignments in a b2xIdentityUserFlow

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId
```
This example shows how to use the New-MgIdentityB2XUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List userAttributeAssignments in a b2xIdentityUserFlow and expand userAttribute

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -ExpandProperty "userAttribute"
```
This example shows how to use the New-MgIdentityB2XUserFlowUserAttributeAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

