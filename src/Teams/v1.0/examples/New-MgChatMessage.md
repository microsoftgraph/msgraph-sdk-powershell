### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	body = @{
		contentType = "html"
		content = "<emoji alt="😶‍🌫️"></emoji>"
	}
}

New-MgChatMessage -ChatId $chatId -BodyParameter $params

```
This example shows how to use the New-MgChatMessage Cmdlet.

