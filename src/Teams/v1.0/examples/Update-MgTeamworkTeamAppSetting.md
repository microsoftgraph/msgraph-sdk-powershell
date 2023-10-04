### Example 1: Update the tenant-wide teamsAppSettings for all Teams apps in the tenant
```powershell
Import-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.teamsAppSettings"
	allowUserRequestsForAppAccess = "true"
}

Update-MgTeamworkTeamAppSetting -BodyParameter $params
```
This example updates the tenant-wide teamsAppSettings for all Teams apps in the tenant