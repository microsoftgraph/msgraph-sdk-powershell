### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#microsoft.graph.aadUserConversationMember"
	roles = @(
		"owner"
	)
}

Update-MgBetaTeamMember -TeamId $teamId -ConversationMemberId $conversationMemberId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

