###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -ExpandProperty "effectiveRules,rules" 
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -Filter "scopeId eq '/' and scopeType eq 'Directory'" -ExpandProperty "rules" 
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -Filter "scopeId eq '/' and scopeType eq 'DirectoryRole'" 
```
