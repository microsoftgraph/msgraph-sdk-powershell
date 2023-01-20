### Example 1: Using the New-MgBetaTeamworkWorkforceIntegration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	DisplayName = "displayName-value"
	ApiVersion = 99
	Encryption = @{
		Protocol = "protocol-value"
		Secret = "secret-value"
	}
	IsActive = $true
	Url = "url-value"
	Supports = "supports-value"
}
New-MgBetaTeamworkWorkforceIntegration -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamworkWorkforceIntegration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
