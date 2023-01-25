### Example 1: Using the Update-MgBetaTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	Roles = @(
		"owner"
	)
}
Update-MgBetaTeamMember -TeamId $teamId -ConversationMemberId $conversationMemberId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
