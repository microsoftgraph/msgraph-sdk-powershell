### Example 1: Retrieve the details of a policy assignment for PIM for Azure AD roles

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId

```
This example will retrieve the details of a policy assignment for pim for azure ad roles

### Example 2: Retrieve the details of a policy assignment for PIM for groups

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId

```
This example will retrieve the details of a policy assignment for pim for groups

