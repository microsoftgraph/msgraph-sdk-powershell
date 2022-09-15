### Example 1: Using the Get-MgOnPremisePublishingProfilePublishedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Get-MgOnPremisePublishingProfilePublishedResource -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -PublishedResourceId $publishedResourceId -ExpandProperty "agentGroups" 
```
This example shows how to use the Get-MgOnPremisePublishingProfilePublishedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgOnPremisePublishingProfilePublishedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Get-MgOnPremisePublishingProfilePublishedResource -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ExpandProperty "agentGroups" 
```
This example shows how to use the Get-MgOnPremisePublishingProfilePublishedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
