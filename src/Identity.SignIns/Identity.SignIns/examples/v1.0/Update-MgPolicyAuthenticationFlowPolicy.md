### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	SelfServiceSignUp = @{
		IsEnabled = $true
	}
}
Update-MgPolicyAuthenticationFlowPolicy -BodyParameter $params
```
