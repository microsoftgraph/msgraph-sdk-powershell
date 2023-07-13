### Example 1: Using the Update-MgBetaTeamworkDeviceSoftware Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	SoftwareType = "teamsClient"
	SoftwareVersion = "1.0.96.22"
}
Update-MgBetaTeamworkDeviceSoftware -TeamworkDeviceId $teamworkDeviceId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamworkDeviceSoftware Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
