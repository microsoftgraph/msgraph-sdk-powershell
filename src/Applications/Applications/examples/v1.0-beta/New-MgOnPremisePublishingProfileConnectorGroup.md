### Example 1: Using the New-MgBetaOnPremisePublishingProfileConnectorGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Name = "name-value"
	IsDefault = $false
}
New-MgBetaOnPremisePublishingProfileConnectorGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -BodyParameter $params
```
This example shows how to use the New-MgBetaOnPremisePublishingProfileConnectorGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaOnPremisePublishingProfileConnectorGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Name = "Connector Group Demo"
}
New-MgBetaOnPremisePublishingProfileConnectorGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -BodyParameter $params
```
This example shows how to use the New-MgBetaOnPremisePublishingProfileConnectorGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
