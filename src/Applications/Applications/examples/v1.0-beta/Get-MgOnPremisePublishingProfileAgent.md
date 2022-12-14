### Example 1: Using the Get-MgBetaOnPremisePublishingProfileAgent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
Get-MgBetaOnPremisePublishingProfileAgent -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ExpandProperty "agentGroups" 
```
This example shows how to use the Get-MgBetaOnPremisePublishingProfileAgent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaOnPremisePublishingProfileAgent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
Get-MgBetaOnPremisePublishingProfileAgent -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -OnPremisesAgentId $onPremisesAgentId -ExpandProperty "agentGroups" 
```
This example shows how to use the Get-MgBetaOnPremisePublishingProfileAgent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
