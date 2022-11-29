### Example 1: Using the Get-MgOnPremisePublishingProfileAgent Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Get-MgOnPremisePublishingProfileAgent -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ExpandProperty "agentGroups" 
```
This example shows how to use the Get-MgOnPremisePublishingProfileAgent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgOnPremisePublishingProfileAgent Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Get-MgOnPremisePublishingProfileAgent -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -OnPremisesAgentId $onPremisesAgentId -ExpandProperty "agentGroups" 
```
This example shows how to use the Get-MgOnPremisePublishingProfileAgent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
