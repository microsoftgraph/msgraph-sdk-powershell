### Example 1: Using the Update-MgBetaOnPremisePublishingProfileAgentGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	DisplayName = "Group New Name"
}
Update-MgBetaOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -OnPremisesAgentGroupId $onPremisesAgentGroupId -BodyParameter $params
```
This example shows how to use the Update-MgBetaOnPremisePublishingProfileAgentGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
