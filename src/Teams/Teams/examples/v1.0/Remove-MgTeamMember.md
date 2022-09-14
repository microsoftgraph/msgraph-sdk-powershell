### Example 1: Using the Remove-MgTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Remove-MgTeamMember -TeamId $teamId -ConversationMemberId $conversationMemberId
```
This example shows how to use the Remove-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
