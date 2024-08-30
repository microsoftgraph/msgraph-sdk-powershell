### Example 1: RRetrieve the details of a policy assignment for PIM for Microsoft Entra roles

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId

```
This example will rretrieve the details of a policy assignment for pim for microsoft entra roles

### Example 2: Retrieve the details of a policy assignment for PIM for Microsoft Entra roles and expand the policy and its associated rules

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId -ExpandProperty "policy(`$expand=rules)" 

```
This example will retrieve the details of a policy assignment for pim for microsoft entra roles and expand the policy and its associated rules

