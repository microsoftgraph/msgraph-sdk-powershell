### Example 1: Update the name of a tab in a chat

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "My Contoso Tab - updated again"
}

Update-MgBetaChatTab -ChatId $chatId -TeamsTabId $teamsTabId -BodyParameter $params
```
This example shows how to use the Update-MgBetaChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

