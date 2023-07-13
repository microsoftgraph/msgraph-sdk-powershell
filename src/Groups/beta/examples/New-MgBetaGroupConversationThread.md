### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	topic = "Take your wellness days and rest"
	posts = @(
		@{
			body = @{
				contentType = "html"
				content = "Waiting for the summer holidays."
			}
		}
	)
}

New-MgBetaGroupConversationThread -GroupId $groupId -ConversationId $conversationId -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupConversationThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

