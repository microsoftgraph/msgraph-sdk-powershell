### Example 1: Using the Get-MgPolicyAppManagementPolicyApplyTo Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyAppManagementPolicyApplyTo -AppManagementPolicyId $appManagementPolicyId
```
This example shows how to use the Get-MgPolicyAppManagementPolicyApplyTo Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgPolicyAppManagementPolicyApplyTo Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyAppManagementPolicyApplyTo -AppManagementPolicyId $appManagementPolicyId -Property "id,appId,displayName,createdDateTime" 
```
This example shows how to use the Get-MgPolicyAppManagementPolicyApplyTo Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
