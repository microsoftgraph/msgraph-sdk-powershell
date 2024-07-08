### Example 1: Retrieve the details of a role management policy

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId
```
This example shows how to use the Get-MgPolicyRoleManagementPolicy Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Retrieve the details of a role management policy and expand the relationships

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -ExpandProperty "effectiveRules,rules"
```
This example shows how to use the Get-MgPolicyRoleManagementPolicy Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

