### Example 1: Using the Update-MgWindowsUpdatesDeploymentAudienceById Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
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
Update-MgWindowsUpdatesDeploymentAudienceById -DeploymentId $deploymentId -BodyParameter $params
```
This example shows how to use the Update-MgWindowsUpdatesDeploymentAudienceById Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
