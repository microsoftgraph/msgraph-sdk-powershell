### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.settingStateDeviceSummary"
	settingName = "Setting Name value"
	instancePath = "Instance Path value"
	unknownDeviceCount = 2
	notApplicableDeviceCount = 8
	compliantDeviceCount = 4
	remediatedDeviceCount = 5
	nonCompliantDeviceCount = 7
	errorDeviceCount = 0
	conflictDeviceCount = 3
}

New-MgDeviceManagementDeviceConfigurationDeviceSettingStateSummary -DeviceConfigurationId $deviceConfigurationId -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceConfigurationDeviceSettingStateSummary Cmdlet.

