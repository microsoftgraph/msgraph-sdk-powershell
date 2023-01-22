### Example 1: Using the Update-MgBetaTeamworkTeamAppSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.teamsAppSettings"
	IsChatResourceSpecificConsentEnabled = "true"
}
Update-MgBetaTeamworkTeamAppSetting -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamworkTeamAppSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
