###Example 1
```
Import-Module Microsoft.Graph.Groups
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
