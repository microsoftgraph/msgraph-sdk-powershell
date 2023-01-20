### Example 1: Using the New-MgBetaUserTeamworkInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"TeamsApp@odata.bind" = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}
New-MgBetaUserTeamworkInstalledApp -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
