### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "my-custom-consent-policy"
	DisplayName = "Custom application consent policy"
	Description = "A custom permission grant policy to customize conditions for granting consent."
}
New-MgPolicyPermissionGrantPolicy -BodyParameter $params
```
