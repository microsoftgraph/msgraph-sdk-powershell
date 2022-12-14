### Example 1: Using the Update-MgBetaWindowsUpdatesDeploymentAudience Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	AddMembers = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.azureADDevice"
			Id = "String (identifier)"
		}
	)
	RemoveMembers = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.azureADDevice"
			Id = "String (identifier)"
		}
	)
	AddExclusions = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.azureADDevice"
			Id = "String (identifier)"
		}
	)
	RemoveExclusions = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.azureADDevice"
			Id = "String (identifier)"
		}
	)
}
Update-MgBetaWindowsUpdatesDeploymentAudience -DeploymentId $deploymentId -BodyParameter $params
```
This example shows how to use the Update-MgBetaWindowsUpdatesDeploymentAudience Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
