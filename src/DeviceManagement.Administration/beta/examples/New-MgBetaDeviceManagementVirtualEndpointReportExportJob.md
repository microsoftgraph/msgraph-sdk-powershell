### Example 1: Create an export job to download the TotalAggregatedRemoteConnectionReports report

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

$params = @{
	reportName = "TotalAggregatedRemoteConnectionReports"
	select = @(
	"CloudPcId"
"ManagedDeviceName"
"UserPrincipalName"
"DaysSinceLastSignIn"
"TotalUsageInHour"
)
}

New-MgBetaDeviceManagementVirtualEndpointReportExportJob -BodyParameter $params

```
This example will create an export job to download the totalaggregatedremoteconnectionreports report

### Example 2: Create an export job to download the RemoteConnectionQualityReports report.

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

$params = @{
	reportName = "RemoteConnectionQualityReports"
	select = @(
	"CloudPcId"
"ManagedDeviceName"
"AvgRoundTripTimeInMsP50"
"LastConnectionRoundTripTimeInMs"
"AvgAvailableBandwidthInMBpsP50"
"LastConnectionAvailableBandWidthInMSps"
"AvgRemoteSignInTimeInSecP50"
"UDPConnectionPercentage"
"LastConnectionGateway"
"LastConnectionProtocol"
"EventDateTime"
)
filter = "EventDateTime gt datetime'2023-06-14T07:40:41.694Z'"
}

New-MgBetaDeviceManagementVirtualEndpointReportExportJob -BodyParameter $params

```
This example will create an export job to download the remoteconnectionqualityreports report.

