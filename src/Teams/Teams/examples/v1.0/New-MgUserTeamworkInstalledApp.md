###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"TeamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}
New-MgUserTeamworkInstalledApp -UserId $userId -BodyParameter $params
```
