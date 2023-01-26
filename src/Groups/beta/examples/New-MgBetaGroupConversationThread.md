### Example 1: Using the New-MgBetaGroupConversationThread Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	Topic = "Take your wellness days and rest"
	Posts = @(
		@{
			Body = @{
				ContentType = "html"
				Content = "Waiting for the summer holidays."
			}
		}
	)
}
New-MgBetaGroupConversationThread -GroupId $groupId -ConversationId $conversationId -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupConversationThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
