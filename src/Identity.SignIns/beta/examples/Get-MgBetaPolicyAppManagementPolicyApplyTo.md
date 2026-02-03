### Example 1: Get applications and service principal objects applied to an app management policy

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyAppManagementPolicyApplyTo -AppManagementPolicyId $appManagementPolicyId

```
This example will get applications and service principal objects applied to an app management policy

### Example 2: Get specific properties of applications and service principal objects applied to an app management policy using $select query option

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyAppManagementPolicyApplyTo -AppManagementPolicyId $appManagementPolicyId -Property "id,appId,displayName,createdDateTime" 

```
This example will get specific properties of applications and service principal objects applied to an app management policy using $select query option

