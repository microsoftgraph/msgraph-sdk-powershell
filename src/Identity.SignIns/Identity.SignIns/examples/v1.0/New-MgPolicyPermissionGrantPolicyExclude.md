###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	PermissionType = "delegated"
	ResourceApplication = "00000003-0000-0000-c000-000000000000"
}
New-MgPolicyPermissionGrantPolicyExclude -PermissionGrantPolicyId $permissionGrantPolicyId -BodyParameter $params
```
