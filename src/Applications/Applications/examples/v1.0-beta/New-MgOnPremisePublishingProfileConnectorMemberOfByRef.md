### Example 1: Using the New-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}"
}
New-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ConnectorId $connectorId -BodyParameter $params
```
This example shows how to use the New-MgBetaOnPremisePublishingProfileConnectorMemberOfByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
