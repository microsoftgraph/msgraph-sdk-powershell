### Example 1: RRetrieve the details of a policy assignment for PIM for Microsoft Entra roles

```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId
```
This example shows how to use the Get-MgBetaPolicyRoleManagementPolicyAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Retrieve the details of a policy assignment for PIM for Microsoft Entra roles and expand the policy and its associated rules

```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId -ExpandProperty "policy(`$expand=rules)"
```
This example shows how to use the Get-MgBetaPolicyRoleManagementPolicyAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

