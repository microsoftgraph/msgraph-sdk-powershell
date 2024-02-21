### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	name = "Name value"
	select = @(
		"Select value"
	)
	search = "Search value"
	groupBy = @(
		"Group By value"
	)
	orderBy = @(
		"Order By value"
	)
	skip = 4
	top = 3
	sessionId = "Session Id value"
	filter = "Filter value"
}

Get-MgDeviceManagementReportSettingNonComplianceReport -BodyParameter $params

```
This example shows how to use the Get-MgDeviceManagementReportSettingNonComplianceReport Cmdlet.

