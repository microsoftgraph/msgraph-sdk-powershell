### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	settings = @{
		description = "dc1 settings new description"
		domainControllerDnsNames = @(
		"DC1.domain1.test.local"
	)
	isDelayedDeploymentEnabled = $false
}
}

Update-MgSecurityIdentitySensor -SensorId $sensorId -BodyParameter $params

```
This example shows how to use the Update-MgSecurityIdentitySensor Cmdlet.

