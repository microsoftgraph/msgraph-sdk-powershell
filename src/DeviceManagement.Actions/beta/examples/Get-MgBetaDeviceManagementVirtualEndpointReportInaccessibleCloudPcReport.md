### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	filter = "region eq 'westus2'"
	orderBy = @(
	"cloudPcId"
)
select = @(
"cloudPcId"
"aadDeviceId"
"cloudPcName"
"userPrincipalName"
"provisioningStatus"
"region"
"deviceHealthStatus"
"deviceHealthStatusDateTime"
"recentDeviceHealthFailureCount"
"recentConnectionFailureCount"
"systemStatus"
"systemStatusDateTime"
)
top = 10
skip = 0
}

Get-MgBetaDeviceManagementVirtualEndpointReportInaccessibleCloudPcReport -BodyParameter $params

```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointReportInaccessibleCloudPcReport Cmdlet.

