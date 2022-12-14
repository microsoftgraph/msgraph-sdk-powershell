### Example 1: Using the New-MgBetaTeamChannelMessageReply Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	Body = @{
		ContentType = "html"
		Content = "Hello World"
	}
}
New-MgBetaTeamChannelMessageReply -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannelMessageReply Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
