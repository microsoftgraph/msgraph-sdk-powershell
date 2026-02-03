### Example 1: Pause a deployment

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.deployment"
	state = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.deploymentState"
		requestedValue = "paused"
	}
}

Update-MgBetaWindowsUpdatesDeployment -DeploymentId $deploymentId -BodyParameter $params

```
This example will pause a deployment

### Example 2: Update deployment settings to add a monitoring rule

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.deployment"
	settings = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.deploymentSettings"
		monitoring = @{
			monitoringRules = @(
				@{
					signal = "rollback"
					threshold = 5
					action = "pauseDeployment"
				}
			)
		}
	}
}

Update-MgBetaWindowsUpdatesDeployment -DeploymentId $deploymentId -BodyParameter $params

```
This example will update deployment settings to add a monitoring rule

