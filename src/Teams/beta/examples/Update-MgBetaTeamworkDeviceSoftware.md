### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	softwareType = "teamsClient"
	softwareVersion = "1.0.96.22"
}

Update-MgBetaTeamworkDeviceSoftware -TeamworkDeviceId $teamworkDeviceId -BodyParameter $params

```
This example shows how to use the Update-MgBetaTeamworkDeviceSoftware Cmdlet.

