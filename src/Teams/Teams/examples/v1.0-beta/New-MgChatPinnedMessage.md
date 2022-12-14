### Example 1: Using the New-MgBetaChatPinnedMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"Message@odata.bind" = "https://graph.microsoft.com/beta/chats/19:2da4c29f6d7041eca70b638b43d45437@thread.v2/messages/1616964509832"
}
New-MgBetaChatPinnedMessage -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatPinnedMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
