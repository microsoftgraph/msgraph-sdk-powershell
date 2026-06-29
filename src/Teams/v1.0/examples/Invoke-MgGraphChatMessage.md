### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	messageIds = @(
	"1728088338580"
)
replyMessage = @{
	body = @{
		content = "Hello World"
	}
}
}

Invoke-MgGraphChatMessage -ChatId $chatId -BodyParameter $params

```
This example shows how to use the Invoke-MgGraphChatMessage Cmdlet.

