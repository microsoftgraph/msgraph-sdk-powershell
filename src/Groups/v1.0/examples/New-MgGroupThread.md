### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	topic = "New Conversation Thread Topic"
	posts = @(
		@{
			body = @{
				contentType = "html"
				content = "this is body content"
			}
			newParticipants = @(
				@{
					emailAddress = @{
						name = "Alex Darrow"
						address = "alexd@contoso.com"
					}
				}
			)
		}
	)
}

New-MgGroupThread -GroupId $groupId -BodyParameter $params

```
This example shows how to use the New-MgGroupThread Cmdlet.

