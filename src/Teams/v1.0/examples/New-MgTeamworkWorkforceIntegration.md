### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	displayName = "ABCWorkforceIntegration"
	apiVersion = 1
	isActive = $true
	encryption = @{
		protocol = "sharedSecret"
		secret = "My Secret"
	}
	url = "https://ABCWorkforceIntegration.com/Contoso/"
	supportedEntities = "Shift,SwapRequest"
	eligibilityFilteringEnabledEntities = "SwapRequest"
}

New-MgTeamworkWorkforceIntegration -BodyParameter $params

```
This example shows how to use the New-MgTeamworkWorkforceIntegration Cmdlet.

