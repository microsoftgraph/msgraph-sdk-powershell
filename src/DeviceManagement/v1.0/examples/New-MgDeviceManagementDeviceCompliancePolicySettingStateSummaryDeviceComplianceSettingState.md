### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceComplianceSettingState"
	setting = "Setting value"
	settingName = "Setting Name value"
	deviceId = "Device Id value"
	deviceName = "Device Name value"
	userId = "User Id value"
	userEmail = "User Email value"
	userName = "User Name value"
	userPrincipalName = "User Principal Name value"
	deviceModel = "Device Model value"
	state = "notApplicable"
	complianceGracePeriodExpirationDateTime = [System.DateTime]::Parse("2016-12-31T23:56:44.951111-08:00")
}

New-MgDeviceManagementDeviceCompliancePolicySettingStateSummaryDeviceComplianceSettingState -DeviceCompliancePolicySettingStateSummaryId $deviceCompliancePolicySettingStateSummaryId -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceCompliancePolicySettingStateSummaryDeviceComplianceSettingState Cmdlet.

