### Example 1: Retrieve a rule defined for a policy in PIM for Microsoft Entra roles

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -UnifiedRoleManagementPolicyRuleId $unifiedRoleManagementPolicyRuleId

```
This example will retrieve a rule defined for a policy in pim for microsoft entra roles

### Example 2: Retrieve a rule defined for a policy in PIM for groups

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -UnifiedRoleManagementPolicyRuleId $unifiedRoleManagementPolicyRuleId

```
This example will retrieve a rule defined for a policy in pim for groups

