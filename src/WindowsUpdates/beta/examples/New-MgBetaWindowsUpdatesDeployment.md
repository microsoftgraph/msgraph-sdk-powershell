### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.deployment"
	content = @{
		"@odata.type" = "#microsoft.graph.windowsUpdates.catalogContent"
		catalogEntry = @{
			"@odata.type" = "#microsoft.graph.windowsUpdates.featureUpdateCatalogEntry"
			id = "f341705b-0b15-4ce3-aaf2-6a1681d78606"
		}
	}
	settings = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.deploymentSettings"
		schedule = @{
			gradualRollout = @{
				"@odata.type" = "#microsoft.graph.windowsUpdates.rateDrivenRolloutSettings"
				durationBetweenOffers = "P7D"
				devicePerOffer = 
			}
		}
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

New-MgBetaWindowsUpdatesDeployment -BodyParameter $params

```
This example shows how to use the New-MgBetaWindowsUpdatesDeployment Cmdlet.

