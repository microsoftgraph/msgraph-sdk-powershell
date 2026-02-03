### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	top = 25
	skip = 0
	filter = "(TotalUsageInHour ge 40 and TotalUsageInHour le 80)"
	select = @(
	"CloudPcId"
"ManagedDeviceName"
"UserPrincipalName"
"TotalUsageInHour"
"LastActiveTime"
"PcType"
"CreatedDate"
)
}

Get-MgBetaDeviceManagementVirtualEndpointReportTotalAggregatedRemoteConnectionReport -BodyParameter $params

```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointReportTotalAggregatedRemoteConnectionReport Cmdlet.

