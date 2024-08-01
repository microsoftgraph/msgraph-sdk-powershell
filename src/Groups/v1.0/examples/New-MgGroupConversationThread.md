### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

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

New-MgGroupConversationThread -GroupId $groupId -ConversationId $conversationId -BodyParameter $params

```
This example shows how to use the New-MgGroupConversationThread Cmdlet.

