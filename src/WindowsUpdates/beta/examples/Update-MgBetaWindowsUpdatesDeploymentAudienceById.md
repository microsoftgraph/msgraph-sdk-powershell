### Example 1: Using the Update-MgBetaWindowsUpdatesDeploymentAudienceById Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	MemberEntityType = "String"
	AddMembers = @(
		"String"
	)
	RemoveMembers = @(
		"String"
	)
	AddExclusions = @(
		"String"
	)
	RemoveExclusions = @(
		"String"
	)
}
Update-MgBetaWindowsUpdatesDeploymentAudienceById -DeploymentId $deploymentId -BodyParameter $params
```
This example shows how to use the Update-MgBetaWindowsUpdatesDeploymentAudienceById Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
