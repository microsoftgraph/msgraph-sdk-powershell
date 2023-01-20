### Example 1: List all the tabs in the chat along with associated Teams app

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatTab -ChatId $chatId -ExpandProperty "teamsApp"
```
This example shows how to use the Get-MgUserChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List all the tabs belonging to a specific app in a chat

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatTab -ChatId $chatId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.web'"
```
This example shows how to use the Get-MgUserChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

