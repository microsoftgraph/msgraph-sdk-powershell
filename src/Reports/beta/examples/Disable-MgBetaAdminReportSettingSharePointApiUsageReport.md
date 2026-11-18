### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Reports

$params = @{
	metric = "egressReport"
}

Disable-MgBetaAdminReportSettingSharePointApiUsageReport -BodyParameter $params

```
This example shows how to use the Disable-MgBetaAdminReportSettingSharePointApiUsageReport Cmdlet.

