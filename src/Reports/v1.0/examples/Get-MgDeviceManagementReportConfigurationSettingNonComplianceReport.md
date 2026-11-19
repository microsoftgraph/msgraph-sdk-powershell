### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Reports

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

Get-MgDeviceManagementReportConfigurationSettingNonComplianceReport -BodyParameter $params

```
This example shows how to use the Get-MgDeviceManagementReportConfigurationSettingNonComplianceReport Cmdlet.

