### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	filter = "DisasterRecoveryStatus eq 'Active outage'"
	select = @(
	"Id"
"CloudPcId"
"UserId"
"UserSettingId"
"DeviceId"
"CloudPCDeviceDisplayName"
"UserPrincipalName"
"IsCrossRegionEnabled"
"CrossRegionHealthStatus"
"LicenseType"
"DisasterRecoveryStatus"
"CurrentRestorePointDateTime"
"ActivationExpirationDateTime"
)
skip = 0
top = 50
}

Get-MgBetaDeviceManagementVirtualEndpointReportCrossRegionDisasterRecoveryReport -BodyParameter $params

```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointReportCrossRegionDisasterRecoveryReport Cmdlet.

