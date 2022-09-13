###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "Custom permission grant policy"
}
Update-MgPolicyPermissionGrantPolicy -PermissionGrantPolicyId $permissionGrantPolicyId -BodyParameter $params
```
