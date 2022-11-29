### Example 1: Using the Update-MgTeamworkDeviceSoftware Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	SoftwareType = "teamsClient"
	SoftwareVersion = "1.0.96.22"
}
Update-MgTeamworkDeviceSoftware -TeamworkDeviceId $teamworkDeviceId -BodyParameter $params
```
This example shows how to use the Update-MgTeamworkDeviceSoftware Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
