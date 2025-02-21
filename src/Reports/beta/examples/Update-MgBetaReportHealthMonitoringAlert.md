### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Reports

$params = @{
	state = "resolved"
}

Update-MgBetaReportHealthMonitoringAlert -AlertId $alertId -BodyParameter $params

```
This example shows how to use the Update-MgBetaReportHealthMonitoringAlert Cmdlet.

