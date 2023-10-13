### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId
```
This example shows how to use the Get-MgBetaPolicyRoleManagementPolicyAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId -ExpandProperty "policy(`$expand=rules)"
```
This example shows how to use the Get-MgBetaPolicyRoleManagementPolicyAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

