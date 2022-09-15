### Example 1: Using the New-MgPolicyPermissionGrantPolicyExclude Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	PermissionType = "delegated"
	ResourceApplication = "00000003-0000-0000-c000-000000000000"
}
New-MgPolicyPermissionGrantPolicyExclude -PermissionGrantPolicyId $permissionGrantPolicyId -BodyParameter $params
```
This example shows how to use the New-MgPolicyPermissionGrantPolicyExclude Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
