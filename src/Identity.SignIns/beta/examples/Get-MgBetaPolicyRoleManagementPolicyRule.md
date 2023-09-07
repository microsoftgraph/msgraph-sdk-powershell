### Example 1: Retrieve a rule defined for a policy in PIM for Azure AD roles

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -UnifiedRoleManagementPolicyRuleId $unifiedRoleManagementPolicyRuleId

```
This example will retrieve a rule defined for a policy in pim for azure ad roles

### Example 2: Retrieve a rule defined for a policy in PIM for groups

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -UnifiedRoleManagementPolicyRuleId $unifiedRoleManagementPolicyRuleId

```
This example will retrieve a rule defined for a policy in pim for groups

