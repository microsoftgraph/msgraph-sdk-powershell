### Example 1: Using the New-MgGroupConversationThread Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
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
New-MgGroupConversationThread -GroupId $groupId -ConversationId $conversationId -BodyParameter $params
```
This example shows how to use the New-MgGroupConversationThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
