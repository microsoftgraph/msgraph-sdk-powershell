### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceComplianceDeviceStatus"
	deviceDisplayName = "Device Display Name value"
	userName = "User Name value"
	deviceModel = "Device Model value"
	complianceGracePeriodExpirationDateTime = [System.DateTime]::Parse("2016-12-31T23:56:44.951111-08:00")
	status = "notApplicable"
	lastReportedDateTime = [System.DateTime]::Parse("2017-01-01T00:00:17.7769392-08:00")
	userPrincipalName = "User Principal Name value"
}

Update-MgDeviceManagementDeviceCompliancePolicyDeviceStatus -DeviceCompliancePolicyId $deviceCompliancePolicyId -DeviceComplianceDeviceStatusId $deviceComplianceDeviceStatusId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceCompliancePolicyDeviceStatus Cmdlet.

