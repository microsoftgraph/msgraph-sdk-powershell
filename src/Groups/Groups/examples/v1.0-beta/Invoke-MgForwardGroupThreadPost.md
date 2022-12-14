### Example 1: Using the Invoke-MgBetaForwardGroupThreadPost Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	Comment = "comment-value"
	ToRecipients = @(
		@{
			EmailAddress = @{
				Name = "name-value"
				Address = "address-value"
			}
		}
	)
}
Invoke-MgBetaForwardGroupThreadPost -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaForwardGroupThreadPost Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
