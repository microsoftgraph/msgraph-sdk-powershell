### Example 1: Using the Set-MgApplicationConnectorGroupByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/onPremisesPublishingProfiles/applicationproxy/connectorGroups/{id}"
}
Set-MgApplicationConnectorGroupByRef -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Set-MgApplicationConnectorGroupByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
