### Example 1: Using the Get-MgOnPremisePublishingProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Get-MgOnPremisePublishingProfile -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ExpandProperty "publishedResources,agents,agentGroups" 
```
This example shows how to use the Get-MgOnPremisePublishingProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
