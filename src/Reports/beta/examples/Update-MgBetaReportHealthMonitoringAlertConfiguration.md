### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Reports

$params = @{
	emailNotificationConfigurations = @(
		@{
			groupId = "c5140914-9507-4180-b60c-04d5ec5eddcb"
			isEnabled = $true
		}
	)
}

Update-MgBetaReportHealthMonitoringAlertConfiguration -AlertConfigurationId $alertConfigurationId -BodyParameter $params

```
This example shows how to use the Update-MgBetaReportHealthMonitoringAlertConfiguration Cmdlet.

