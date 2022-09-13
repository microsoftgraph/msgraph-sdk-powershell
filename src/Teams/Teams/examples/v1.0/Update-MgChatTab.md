###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "My Contoso Tab - updated again"
}
Update-MgChatTab -ChatId $chatId -TeamsTabId $teamsTabId -BodyParameter $params
```
