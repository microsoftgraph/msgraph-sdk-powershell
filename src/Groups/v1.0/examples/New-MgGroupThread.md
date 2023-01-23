### Example 1: Using the New-MgGroupThread Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	Topic = "New Conversation Thread Topic"
	Posts = @(
		@{
			Body = @{
				ContentType = "html"
				Content = "this is body content"
			}
			NewParticipants = @(
				@{
					EmailAddress = @{
						Name = "Alex Darrow"
						Address = "alexd@contoso.com"
					}
				}
			)
		}
	)
}
New-MgGroupThread -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgGroupThread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
