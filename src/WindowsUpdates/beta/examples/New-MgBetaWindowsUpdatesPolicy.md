### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.updatePolicy"
	audience = @{
		id = "8c4eb1eb-d7a3-4633-8e2f-f926e82df08e"
	}
	complianceChanges = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.contentApproval"
		}
	)
	complianceChangeRules = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.contentApprovalRule"
			contentFilter = @{
				"@odata.type" = "#microsoft.graph.windowsUpdates.driverUpdateFilter"
			}
			durationBeforeDeploymentStart = "P7D"
		}
	)
	deploymentSettings = @{
		"@odata.type" = "microsoft.graph.windowsUpdates.deploymentSettings"
		schedule = @{
			gradualRollout = @{
				"@odata.type" = "#microsoft.graph.windowsUpdates.rateDrivenRolloutSettings"
				durationBetweenOffers = "P1D"
				devicePerOffer = 
			}
		}
	}
}

New-MgBetaWindowsUpdatesPolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaWindowsUpdatesPolicy Cmdlet.

