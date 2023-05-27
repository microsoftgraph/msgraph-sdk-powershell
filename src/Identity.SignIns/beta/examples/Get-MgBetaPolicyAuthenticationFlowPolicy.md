### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	selfServiceSignUp = @{
		isEnabled = $true
	}
}

Update-MgBetaPolicyAuthenticationFlowPolicy -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaPolicyAuthenticationFlowPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

