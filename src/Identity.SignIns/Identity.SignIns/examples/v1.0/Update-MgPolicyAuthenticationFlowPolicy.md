###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	SelfServiceSignUp = @{
		IsEnabled = $true
	}
}
Update-MgPolicyAuthenticationFlowPolicy -BodyParameter $params
```
