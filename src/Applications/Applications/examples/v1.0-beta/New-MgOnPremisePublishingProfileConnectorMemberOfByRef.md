### Example 1: Using the New-MgOnPremisePublishingProfileConnectorMemberOfByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}"
}
New-MgOnPremisePublishingProfileConnectorMemberOfByRef -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ConnectorId $connectorId -BodyParameter $params
```
This example shows how to use the New-MgOnPremisePublishingProfileConnectorMemberOfByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
