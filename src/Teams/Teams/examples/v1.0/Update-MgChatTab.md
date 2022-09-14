### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "My Contoso Tab - updated again"
}
Update-MgChatTab -ChatId $chatId -TeamsTabId $teamsTabId -BodyParameter $params
```
