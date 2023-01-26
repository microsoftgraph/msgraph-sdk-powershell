### Example 1: Using the Set-MgBetaApplicationConnectorGroupByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/onPremisesPublishingProfiles/applicationproxy/connectorGroups/{id}"
}
Set-MgBetaApplicationConnectorGroupByRef -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Set-MgBetaApplicationConnectorGroupByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
