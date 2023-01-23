### Example 1: Code snippet

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
This example shows how to use the Invoke-MgBetaForwardGroupThreadPostInReplyTo Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

