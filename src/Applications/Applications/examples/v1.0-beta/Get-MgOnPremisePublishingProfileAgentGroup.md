### Example 1: Using the Get-MgOnPremisePublishingProfileAgentGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Get-MgOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ExpandProperty "agents,publishedResources" 
```
This example shows how to use the Get-MgOnPremisePublishingProfileAgentGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgOnPremisePublishingProfileAgentGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Get-MgOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -OnPremisesAgentGroupId $onPremisesAgentGroupId -ExpandProperty "publishedResources,agents" 
```
This example shows how to use the Get-MgOnPremisePublishingProfileAgentGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
