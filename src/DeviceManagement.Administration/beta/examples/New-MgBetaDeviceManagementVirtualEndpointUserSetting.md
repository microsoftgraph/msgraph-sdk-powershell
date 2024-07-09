### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcUserSetting"
	displayName = "Example"
	selfServiceEnabled = $false
	localAdminEnabled = $true
	restorePointSetting = @{
		frequencyInHours = 16
		frequencyType = "sixteenHours"
		userRestoreEnabled = $true
	}
}

New-MgBetaDeviceManagementVirtualEndpointUserSetting -BodyParameter $params

```
This example shows how to use the New-MgBetaDeviceManagementVirtualEndpointUserSetting Cmdlet.

