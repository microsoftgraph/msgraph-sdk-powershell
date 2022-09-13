###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	IsEnabled = $false
}
Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy -BodyParameter $params
```
