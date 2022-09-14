### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "CrossTenantAccessPolicy"
}
Update-MgPolicyCrossTenantAccessPolicy -BodyParameter $params
```
