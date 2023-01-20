### Example 1: Using the New-MgBetaTeamInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"TeamsApp@odata.bind" = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}
New-MgBetaTeamInstalledApp -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
