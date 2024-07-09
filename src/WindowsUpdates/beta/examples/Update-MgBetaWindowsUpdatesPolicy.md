### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.updatePolicy"
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

Update-MgBetaWindowsUpdatesPolicy -UpdatePolicyId $updatePolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaWindowsUpdatesPolicy Cmdlet.

