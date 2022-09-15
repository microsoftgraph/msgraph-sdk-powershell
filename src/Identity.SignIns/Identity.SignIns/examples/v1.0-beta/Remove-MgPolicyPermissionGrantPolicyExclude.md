### Example 1: Using the Remove-MgPolicyPermissionGrantPolicyExclude Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Remove-MgPolicyPermissionGrantPolicyExclude -PermissionGrantPolicyId $permissionGrantPolicyId -PermissionGrantConditionSetId $permissionGrantConditionSetId
```
This example shows how to use the Remove-MgPolicyPermissionGrantPolicyExclude Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
