### Example 1: Get device recommendation reports grouped by service plan and usage category

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	reportType = "cloudPcUsageCategoryReport"
	select = @(
	"ServicePlanId"
"ServicePlanName"
"UsageInsight"
)
groupBy = @(
"ServicePlanId"
"ServicePlanName"
"UsageInsight"
)
}

Get-MgDeviceManagementVirtualEndpointReportCloudPcRecommendationReport -BodyParameter $params

```
This example will get device recommendation reports grouped by service plan and usage category

### Example 2: Get device usage category reports for Cloud PCs

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	reportType = "cloudPcUsageCategoryReport"
	filter = ""
	select = @(
	"CloudPcId"
"ManagedDeviceName"
"UserPrincipalName"
"ServicePlanId"
"ServicePlanName"
"UsageInsight"
"RecommendedPlanId"
"RecommendedPlanName"
)
search = ""
skip = 0
top = 15
}

Get-MgDeviceManagementVirtualEndpointReportCloudPcRecommendationReport -BodyParameter $params

```
This example will get device usage category reports for cloud pcs

