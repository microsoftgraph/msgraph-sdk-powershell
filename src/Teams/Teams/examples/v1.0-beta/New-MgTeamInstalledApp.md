### Example 1: Using the New-MgTeamInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	"TeamsApp@odata.bind" = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}
New-MgTeamInstalledApp -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
