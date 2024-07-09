### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcUserSetting"
	displayName = "Example"
	restorePointSetting = @{
		frequencyType = "sixteenHours"
		userRestoreEnabled = $true
	}
	localAdminEnabled = $false
	resetEnabled = $true
}

Update-MgDeviceManagementVirtualEndpointUserSetting -CloudPcUserSettingId $cloudPcUserSettingId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementVirtualEndpointUserSetting Cmdlet.

