### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcUserSetting"
	displayName = "Example"
	selfServiceEnabled = $true
	restorePointSetting = @{
		frequencyInHours = 16
		frequencyType = "sixteenHours"
		userRestoreEnabled = $true
	}
	crossRegionDisasterRecoverySetting = @{
		crossRegionDisasterRecoveryEnabled = $false
		maintainCrossRegionRestorePointEnabled = $true
		disasterRecoveryNetworkSetting = @{
			regionName = "westus"
			regionGroup = "usEast"
		}
		disasterRecoveryType = "premium"
		userInitiatedDisasterRecoveryAllowed = $true
	}
	provisioningSourceType = "image"
	localAdminEnabled = $false
	resetEnabled = $true
}

Update-MgBetaDeviceManagementVirtualEndpointUserSetting -CloudPcUserSettingId $cloudPcUserSettingId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDeviceManagementVirtualEndpointUserSetting Cmdlet.

