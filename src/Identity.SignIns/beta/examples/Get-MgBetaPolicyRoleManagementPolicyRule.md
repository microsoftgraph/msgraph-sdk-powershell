### Example 1: Retrieve rules of a policy in PIM for Microsoft Entra roles

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId

```
This example will retrieve rules of a policy in pim for microsoft entra roles

### Example 2: Retrieve rules of a policy in PIM for groups

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId

```
This example will retrieve rules of a policy in pim for groups

