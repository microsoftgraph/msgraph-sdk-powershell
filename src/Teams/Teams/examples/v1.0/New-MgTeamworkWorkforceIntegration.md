### Example 1
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
