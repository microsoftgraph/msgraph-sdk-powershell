### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/onPremisesPublishingProfiles/applicationproxy/connectorGroups/{id}"
}

Set-MgBetaApplicationConnectorGroupByRef -ApplicationId $applicationId -BodyParameter $params

```
This example shows how to use the Set-MgBetaApplicationConnectorGroupByRef Cmdlet.

