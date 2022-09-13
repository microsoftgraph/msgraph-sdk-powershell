###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	Body = @{
		ContentType = "html"
		Content = "Hello World"
	}
}
New-MgTeamChannelMessageReply -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
$params = @{
	Body = @{
		ContentType = "html"
		Content = "Hello World"
	}
}
New-MgTeamChannelMessageReply -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId -BodyParameter $params
```
