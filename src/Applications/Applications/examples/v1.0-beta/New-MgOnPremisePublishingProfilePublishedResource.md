### Example 1: Using the New-MgOnPremisePublishingProfilePublishedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	DisplayName = "New provisioning"
	ResourceName = "domain1.contoso.com"
}
New-MgOnPremisePublishingProfilePublishedResource -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -BodyParameter $params
```
This example shows how to use the New-MgOnPremisePublishingProfilePublishedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
