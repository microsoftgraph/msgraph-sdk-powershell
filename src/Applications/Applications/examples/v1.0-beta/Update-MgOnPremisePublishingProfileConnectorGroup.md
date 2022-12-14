### Example 1: Using the Update-MgBetaOnPremisePublishingProfileConnectorGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Name = "name-value"
	Region = "region-value"
}
Update-MgBetaOnPremisePublishingProfileConnectorGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ConnectorGroupId $connectorGroupId -BodyParameter $params
```
This example shows how to use the Update-MgBetaOnPremisePublishingProfileConnectorGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
