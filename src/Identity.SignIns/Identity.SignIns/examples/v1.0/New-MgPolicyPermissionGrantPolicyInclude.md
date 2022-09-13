###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	PermissionType = "delegated"
	ClientApplicationsFromVerifiedPublisherOnly = $true
}
New-MgPolicyPermissionGrantPolicyInclude -PermissionGrantPolicyId $permissionGrantPolicyId -BodyParameter $params
```
