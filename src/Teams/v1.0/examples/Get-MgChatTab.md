### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatTab -ChatId $chatId -TeamsTabId $teamsTabId -ExpandProperty "teamsApp"
```
This example shows how to use the Get-MgChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

