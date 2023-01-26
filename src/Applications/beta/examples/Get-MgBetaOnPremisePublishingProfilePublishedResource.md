### Example 1: Using the Get-MgBetaOnPremisePublishingProfilePublishedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
Get-MgBetaOnPremisePublishingProfilePublishedResource -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -PublishedResourceId $publishedResourceId -ExpandProperty "agentGroups" 
```
This example shows how to use the Get-MgBetaOnPremisePublishingProfilePublishedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaOnPremisePublishingProfilePublishedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
Get-MgBetaOnPremisePublishingProfilePublishedResource -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ExpandProperty "agentGroups" 
```
This example shows how to use the Get-MgBetaOnPremisePublishingProfilePublishedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
