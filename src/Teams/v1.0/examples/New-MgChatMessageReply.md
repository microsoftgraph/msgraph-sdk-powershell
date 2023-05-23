### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	body = @{
		contentType = "html"
		content = "Hello World"
	}
}

New-MgTeamChannelMessageReply -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the New-MgChatMessageReply Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

