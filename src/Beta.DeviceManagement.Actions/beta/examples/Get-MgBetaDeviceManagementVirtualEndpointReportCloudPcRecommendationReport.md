### Example 1: List recommendation reports by device

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	reportName = "cloudPcUsageCategoryReports"
	top = 50
	skip = 0
	search = ""
	filter = ""
	select = @(
	"CloudPcId"
"ManagedDeviceName"
"UserPrincipalName"
"UsageInsight"
"CurrentSize"
"RecommendedSize"
"UsageInHour"
"DevicePerfSummary"
)
orderBy = @(
"ManagedDeviceName"
)
}

Get-MgBetaDeviceManagementVirtualEndpointReportCloudPcRecommendationReport -BodyParameter $params

```
This example will list recommendation reports by device

### Example 2: Get summary reports by usage insight

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	reportName = "cloudPcUsageCategoryReports"
	select = @(
	"UsageInsight"
)
groupBy = @(
"UsageInsight"
)
filter = ""
}

Get-MgBetaDeviceManagementVirtualEndpointReportCloudPcRecommendationReport -BodyParameter $params

```
This example will get summary reports by usage insight

