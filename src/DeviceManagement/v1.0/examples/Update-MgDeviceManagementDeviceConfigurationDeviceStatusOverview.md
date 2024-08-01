### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceConfigurationDeviceOverview"
	pendingCount = 12
	notApplicableCount = 2
	successCount = 12
	errorCount = 10
	failedCount = 11
	lastUpdateDateTime = [System.DateTime]::Parse("2016-12-31T23:58:21.6459442-08:00")
	configurationVersion = 4
}

Update-MgDeviceManagementDeviceConfigurationDeviceStatusOverview -DeviceConfigurationId $deviceConfigurationId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceConfigurationDeviceStatusOverview Cmdlet.

