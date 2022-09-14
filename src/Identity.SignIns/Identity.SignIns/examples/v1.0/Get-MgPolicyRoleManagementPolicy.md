### Example 1: Using the Get-MgPolicyRoleManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId -ExpandProperty "effectiveRules,rules" 
```
This example shows how to use the Get-MgPolicyRoleManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgPolicyRoleManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -UnifiedRoleManagementPolicyId $unifiedRoleManagementPolicyId
```
This example shows how to use the Get-MgPolicyRoleManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgPolicyRoleManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -Filter "scopeId eq '/' and scopeType eq 'Directory'" -ExpandProperty "rules" 
```
This example shows how to use the Get-MgPolicyRoleManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgPolicyRoleManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyRoleManagementPolicy -Filter "scopeId eq '/' and scopeType eq 'DirectoryRole'" 
```
This example shows how to use the Get-MgPolicyRoleManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
