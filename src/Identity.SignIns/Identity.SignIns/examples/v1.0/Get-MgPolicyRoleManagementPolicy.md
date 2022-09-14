### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -ExpandProperty "effectiveRules,rules" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -Filter "scopeId eq '/' and scopeType eq 'Directory'" -ExpandProperty "rules" 
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -Filter "scopeId eq '/' and scopeType eq 'DirectoryRole'" 
```
