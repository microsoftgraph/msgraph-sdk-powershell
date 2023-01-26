### Example 1: Using the Get-MgBetaOnPremisePublishingProfileAgentGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
Get-MgBetaOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ExpandProperty "agents,publishedResources" 
```
This example shows how to use the Get-MgBetaOnPremisePublishingProfileAgentGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaOnPremisePublishingProfileAgentGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
Get-MgBetaOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -OnPremisesAgentGroupId $onPremisesAgentGroupId -ExpandProperty "publishedResources,agents" 
```
This example shows how to use the Get-MgBetaOnPremisePublishingProfileAgentGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
