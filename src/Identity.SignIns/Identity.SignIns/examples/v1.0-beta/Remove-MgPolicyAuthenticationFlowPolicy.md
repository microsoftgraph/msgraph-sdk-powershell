### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	SelfServiceSignUp = @{
		IsEnabled = $true
	}
}

Update-MgPolicyAuthenticationFlowPolicy -BodyParameter $params
```
This example shows how to use the Remove-MgPolicyAuthenticationFlowPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

