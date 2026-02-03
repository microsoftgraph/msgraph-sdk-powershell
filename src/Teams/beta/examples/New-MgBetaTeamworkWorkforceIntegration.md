### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "displayName-value"
	apiVersion = 99
	encryption = @{
		protocol = "protocol-value"
		secret = "secret-value"
	}
	isActive = $true
	url = "url-value"
	supports = "supports-value"
}

New-MgBetaTeamworkWorkforceIntegration -BodyParameter $params

```
This example shows how to use the New-MgBetaTeamworkWorkforceIntegration Cmdlet.

