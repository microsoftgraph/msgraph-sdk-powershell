### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceConfigurationDeviceStateSummary"
	unknownDeviceCount = 2
	notApplicableDeviceCount = 8
	compliantDeviceCount = 4
	remediatedDeviceCount = 5
	nonCompliantDeviceCount = 7
	errorDeviceCount = 0
	conflictDeviceCount = 3
}

Update-MgDeviceManagementDeviceConfigurationDeviceStateSummary -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceConfigurationDeviceStateSummary Cmdlet.

