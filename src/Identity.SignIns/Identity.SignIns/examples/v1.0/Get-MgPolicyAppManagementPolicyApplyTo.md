### Example 1: Get applications and service principal objects applied to an app management policy

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyAppManagementPolicyApplyTo -AppManagementPolicyId $appManagementPolicyId
```
This example shows how to use the Get-MgPolicyAppManagementPolicyApplyTo Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get specific properties of applications and service principal objects applied to an app management policy using $select query option

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyAppManagementPolicyApplyTo -AppManagementPolicyId $appManagementPolicyId -Property "id,appId,displayName,createdDateTime"
```
This example shows how to use the Get-MgPolicyAppManagementPolicyApplyTo Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

