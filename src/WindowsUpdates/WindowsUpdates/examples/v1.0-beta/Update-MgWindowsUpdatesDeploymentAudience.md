### Example 1: Using the Update-MgWindowsUpdatesDeploymentAudience Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
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
Update-MgWindowsUpdatesDeploymentAudience -DeploymentId $deploymentId -BodyParameter $params
```
This example shows how to use the Update-MgWindowsUpdatesDeploymentAudience Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
