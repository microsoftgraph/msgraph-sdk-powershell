### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceInstallState"
	deviceName = "Device Name value"
	deviceId = "Device Id value"
	lastSyncDateTime = [System.DateTime]::Parse("2017-01-01T00:02:49.3205976-08:00")
	installState = "installed"
	errorCode = "Error Code value"
	osVersion = "Os Version value"
	osDescription = "Os Description value"
	userName = "User Name value"
}

Update-MgDeviceAppManagementManagedEBookDeviceState -ManagedEBookId $managedEBookId -DeviceInstallStateId $deviceInstallStateId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementManagedEBookDeviceState Cmdlet.

