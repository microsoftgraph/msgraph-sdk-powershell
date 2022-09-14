### Example 1
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
