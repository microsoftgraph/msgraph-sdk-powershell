### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"message@odata.bind" = "https://graph.microsoft.com/v1.0/chats/19:2da4c29f6d7041eca70b638b43d45437@thread.v2/messages/1616964509832"
}

New-MgBetaChatPinnedMessage -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaChatPinnedMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

