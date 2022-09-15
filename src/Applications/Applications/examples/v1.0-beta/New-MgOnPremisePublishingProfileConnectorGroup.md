### Example 1: Using the New-MgOnPremisePublishingProfileConnectorGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	Name = "name-value"
	IsDefault = $false
}
New-MgOnPremisePublishingProfileConnectorGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -BodyParameter $params
```
This example shows how to use the New-MgOnPremisePublishingProfileConnectorGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgOnPremisePublishingProfileConnectorGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	Name = "Connector Group Demo"
}
New-MgOnPremisePublishingProfileConnectorGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -BodyParameter $params
```
This example shows how to use the New-MgOnPremisePublishingProfileConnectorGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
