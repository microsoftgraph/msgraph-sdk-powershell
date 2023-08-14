### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	body = @{
		contentType = "html"
		content = "Hello World"
	}
}

New-MgBetaTeamChannelMessageReply -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params

```
This example shows how to use the New-MgBetaTeamChannelMessageReply Cmdlet.

