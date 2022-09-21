### Example 1: Using the Update-MgWindowsUpdatesDeployment Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.deployment"
	State = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.deploymentState"
		RequestedValue = "paused"
	}
}
Update-MgWindowsUpdatesDeployment -DeploymentId $deploymentId -BodyParameter $params
```
This example shows how to use the Update-MgWindowsUpdatesDeployment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgWindowsUpdatesDeployment Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.deployment"
	Settings = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.windowsDeploymentSettings"
		Monitoring = @{
			MonitoringRules = @(
				@{
					Signal = "rollback"
					Threshold = 5
					Action = "pauseDeployment"
				}
			)
		}
	}
}
Update-MgWindowsUpdatesDeployment -DeploymentId $deploymentId -BodyParameter $params
```
This example shows how to use the Update-MgWindowsUpdatesDeployment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
