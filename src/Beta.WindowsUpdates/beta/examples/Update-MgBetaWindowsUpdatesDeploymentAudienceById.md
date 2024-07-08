### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	memberEntityType = "String"
	addMembers = @(
	"String"
)
removeMembers = @(
"String"
)
addExclusions = @(
"String"
)
removeExclusions = @(
"String"
)
}

Update-MgBetaWindowsUpdatesDeploymentAudienceById -DeploymentId $deploymentId -BodyParameter $params

```
This example shows how to use the Update-MgBetaWindowsUpdatesDeploymentAudienceById Cmdlet.

