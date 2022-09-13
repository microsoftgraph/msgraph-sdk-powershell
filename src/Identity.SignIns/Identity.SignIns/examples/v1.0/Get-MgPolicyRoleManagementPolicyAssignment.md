###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId -ExpandProperty "policy(`$expand=rules)" 
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicyAssignment -UnifiedRoleManagementPolicyAssignmentId $unifiedRoleManagementPolicyAssignmentId
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicyAssignment -Filter "scopeId eq '/' and scopeType eq 'DirectoryRole' and roleDefinitionId eq '62e90394-69f5-4237-9190-012177145e10'" -ExpandProperty "policy(`$expand=rules)" 
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicyAssignment -Filter "scopeId eq '/' and scopeType eq 'Directory'" 
```
