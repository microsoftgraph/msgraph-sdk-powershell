### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Reports

$params = @{
	metric = "egressReport"
}

Enable-MgBetaAdminReportSettingSharePointApiUsageReport -BodyParameter $params

```
This example shows how to use the Enable-MgBetaAdminReportSettingSharePointApiUsageReport Cmdlet.

