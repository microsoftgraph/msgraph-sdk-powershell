### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	roles = @(
		"owner"
	)
}

Update-MgTeamChannelMember -TeamId $teamId -ChannelId $channelId -ConversationMemberId $conversationMemberId -BodyParameter $params
```
This example shows how to use the Update-MgTeamChannelMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

