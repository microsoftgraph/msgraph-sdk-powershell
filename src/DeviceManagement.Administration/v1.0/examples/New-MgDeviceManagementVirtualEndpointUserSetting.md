### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcUserSetting"
	displayName = "Example"
	localAdminEnabled = $true
	restorePointSetting = @{
		frequencyType = "sixteenHours"
		userRestoreEnabled = $true
	}
}

New-MgDeviceManagementVirtualEndpointUserSetting -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementVirtualEndpointUserSetting Cmdlet.

