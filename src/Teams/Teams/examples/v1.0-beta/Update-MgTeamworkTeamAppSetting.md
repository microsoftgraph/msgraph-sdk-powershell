### Example 1: Using the Update-MgTeamworkTeamAppSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.teamsAppSettings"
	IsChatResourceSpecificConsentEnabled = "true"
}
Update-MgTeamworkTeamAppSetting -BodyParameter $params
```
This example shows how to use the Update-MgTeamworkTeamAppSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
