### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -UnifiedRoleManagementPolicyRuleId $unifiedRoleManagementPolicyRuleId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId
```
