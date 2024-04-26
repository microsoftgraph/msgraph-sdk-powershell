### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -ExpandProperty "agents,publishedResources" 

```
This example shows how to use the Get-MgBetaOnPremisePublishingProfileAgentGroup Cmdlet.

