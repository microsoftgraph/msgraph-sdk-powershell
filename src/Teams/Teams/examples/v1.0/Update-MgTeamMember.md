###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
}
Update-MgTeamMember -TeamId $teamId -ConversationMemberId $conversationMemberId -BodyParameter $params
```
