###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
}
Update-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -ConversationMemberId $conversationMemberId -BodyParameter $params
```
