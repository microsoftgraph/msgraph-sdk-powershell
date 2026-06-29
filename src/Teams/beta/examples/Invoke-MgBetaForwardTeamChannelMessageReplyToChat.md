### Example 1: Forward a reply message from a channel to a chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	targetChatIds = @(
	"19:e2ed97baac8e4bffbb91299a38996790@thread.v2"
)
messageIds = @(
"1728088338580"
)
additionalMessage = @{
body = @{
	content = "Hello World"
}
}
}

Invoke-MgBetaForwardTeamChannelMessageReplyToChat -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params

```
This example will forward a reply message from a channel to a chat

