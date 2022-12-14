### Example 1: Using the New-MgBetaWindowsUpdatesDeployment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.deployment"
	Content = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.featureUpdateReference"
		Version = "20H2"
	}
	Settings = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.windowsDeploymentSettings"
		Rollout = @{
			DevicesPerOffer = 100
		}
		Monitoring = @{
			MonitoringRules = @(
				@{
					"@odata.type" = "#microsoft.graph.windowsUpdates.monitoringRule"
					Signal = "rollback"
					Threshold = 5
					Action = "pauseDeployment"
				}
			)
		}
	}
}
New-MgBetaWindowsUpdatesDeployment -BodyParameter $params
```
This example shows how to use the New-MgBetaWindowsUpdatesDeployment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
