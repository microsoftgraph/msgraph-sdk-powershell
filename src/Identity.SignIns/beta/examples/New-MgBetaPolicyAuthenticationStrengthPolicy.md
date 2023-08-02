### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.authenticationStrengthPolicy"
	displayName = "Contoso authentication level"
	description = "The only authentication level allowed to access our secret apps"
	allowedCombinations = @(
		"password, hardwareOath"
		"password, sms"
	)
}

New-MgBetaPolicyAuthenticationStrengthPolicy -BodyParameter $params
```
This example shows how to use the New-MgBetaPolicyAuthenticationStrengthPolicy Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

