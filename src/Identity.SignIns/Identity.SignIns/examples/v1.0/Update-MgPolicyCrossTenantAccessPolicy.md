###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "CrossTenantAccessPolicy"
}
Update-MgPolicyCrossTenantAccessPolicy -BodyParameter $params
```
