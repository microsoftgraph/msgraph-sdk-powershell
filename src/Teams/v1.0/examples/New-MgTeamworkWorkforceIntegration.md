### Example 1: Using the New-MgTeamworkWorkforceIntegration Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "displayName-value"
	ApiVersion = 99
	Encryption = @{
		Protocol = "protocol-value"
		Secret = "secret-value"
	}
	IsActive = $true
	Url = "url-value"
	SupportedEntities = "supportedEntities-value"
}
New-MgTeamworkWorkforceIntegration -BodyParameter $params
```
This example shows how to use the New-MgTeamworkWorkforceIntegration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
