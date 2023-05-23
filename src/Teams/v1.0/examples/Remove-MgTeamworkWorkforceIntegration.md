### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	displayName = "displayName-value"
	apiVersion = 99
	encryption = @{
		protocol = "protocol-value"
		secret = "secret-value"
	}
	isActive = $true
	url = "url-value"
	supportedEntities = "supportedEntities-value"
}

Update-MgTeamworkWorkforceIntegration -WorkforceIntegrationId $workforceIntegrationId -BodyParameter $params
```
This example shows how to use the Remove-MgTeamworkWorkforceIntegration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

