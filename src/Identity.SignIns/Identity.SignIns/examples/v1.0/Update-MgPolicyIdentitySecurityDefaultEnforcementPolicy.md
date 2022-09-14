### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	IsEnabled = $false
}
Update-MgPolicyIdentitySecurityDefaultEnforcementPolicy -BodyParameter $params
```
