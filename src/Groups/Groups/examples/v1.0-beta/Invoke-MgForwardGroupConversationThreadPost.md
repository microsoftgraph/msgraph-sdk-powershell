### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Groups

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

Invoke-MgForwardGroupThreadPost -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -BodyParameter $params
```
This example shows how to use the Invoke-MgForwardGroupConversationThreadPost Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

