### Example 1: Using the Update-MgOnPremisePublishingProfileConnectorGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	Name = "name-value"
	Region = "region-value"
}
Update-MgOnPremisePublishingProfileConnectorGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ConnectorGroupId $connectorGroupId -BodyParameter $params
```
This example shows how to use the Update-MgOnPremisePublishingProfileConnectorGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
