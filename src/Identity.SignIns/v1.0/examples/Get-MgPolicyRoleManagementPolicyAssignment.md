### Example 1: Retrieve a role management policy assignment

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId
```
This example shows how to use the Get-MgPolicyRoleManagementPolicyAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Retrieve a role management policy assignment and expand the policy and its associated rules

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId -ExpandProperty "policy(`$expand=rules)"
```
This example shows how to use the Get-MgPolicyRoleManagementPolicyAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

