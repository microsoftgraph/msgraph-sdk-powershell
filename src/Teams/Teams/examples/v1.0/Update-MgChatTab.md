### Example 1: Using the Update-MgChatTab Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "My Contoso Tab - updated again"
}
Update-MgChatTab -ChatId $chatId -TeamsTabId $teamsTabId -BodyParameter $params
```
This example shows how to use the Update-MgChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
