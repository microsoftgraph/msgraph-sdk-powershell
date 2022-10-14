### Example 1: Using the New-MgTeamChannelMessageReply Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Body = @{
		ContentType = "html"
		Content = "Hello World"
	}
}
New-MgTeamChannelMessageReply -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the New-MgTeamChannelMessageReply Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
