### Example 1: Using the Update-MgPolicyAuthenticationFlowPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	SelfServiceSignUp = @{
		IsEnabled = $true
	}
}
Update-MgPolicyAuthenticationFlowPolicy -BodyParameter $params
```
This example shows how to use the Update-MgPolicyAuthenticationFlowPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
