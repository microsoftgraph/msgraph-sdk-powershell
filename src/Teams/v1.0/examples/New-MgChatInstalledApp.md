### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}

New-MgChatInstalledApp -ChatId $chatId -BodyParameter $params

```
This example shows how to use the New-MgChatInstalledApp Cmdlet.

