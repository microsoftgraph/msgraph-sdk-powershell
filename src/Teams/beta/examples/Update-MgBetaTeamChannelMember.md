### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	roles = @(
	"owner"
)
}

Update-MgBetaTeamChannelMember -TeamId $teamId -ChannelId $channelId -ConversationMemberId $conversationMemberId -BodyParameter $params

```
This example shows how to use the Update-MgBetaTeamChannelMember Cmdlet.

