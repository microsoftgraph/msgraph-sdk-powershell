### Example 1: Using the New-MgBetaChatInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"TeamsApp@odata.bind" = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}
New-MgBetaChatInstalledApp -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
