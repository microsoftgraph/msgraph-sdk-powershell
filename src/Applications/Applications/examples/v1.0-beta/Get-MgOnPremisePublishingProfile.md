### Example 1: Using the Get-MgBetaOnPremisePublishingProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
Get-MgBetaOnPremisePublishingProfile -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ExpandProperty "publishedResources,agents,agentGroups" 
```
This example shows how to use the Get-MgBetaOnPremisePublishingProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
