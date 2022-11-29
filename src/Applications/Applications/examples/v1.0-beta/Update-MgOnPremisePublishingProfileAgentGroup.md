### Example 1: Using the Update-MgOnPremisePublishingProfileAgentGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	DisplayName = "Group New Name"
}
Update-MgOnPremisePublishingProfileAgentGroup -OnPremisesPublishingProfileId $onPremisesPublishingProfileId -OnPremisesAgentGroupId $onPremisesAgentGroupId -BodyParameter $params
```
This example shows how to use the Update-MgOnPremisePublishingProfileAgentGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
