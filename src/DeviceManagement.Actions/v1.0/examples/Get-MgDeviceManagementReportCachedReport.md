### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	id = "Id value"
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
}

Get-MgDeviceManagementReportCachedReport -BodyParameter $params

```
This example shows how to use the Get-MgDeviceManagementReportCachedReport Cmdlet.

