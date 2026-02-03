### Example 1: Using the New-MgBetaOnPremisePublishingProfilePublishedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	DisplayName = "New provisioning"
	ResourceName = "domain1.contoso.com"
}
New-MgBetaOnPremisePublishingProfilePublishedResource -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -BodyParameter $params
```
This example shows how to use the New-MgBetaOnPremisePublishingProfilePublishedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
