### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Remove-MgPolicyPermissionGrantPolicyExclude -PermissionGrantPolicyId $permissionGrantPolicyId -PermissionGrantConditionSetId $permissionGrantConditionSetId
```
