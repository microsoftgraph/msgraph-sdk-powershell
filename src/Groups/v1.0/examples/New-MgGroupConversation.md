### Example 1: Using the New-MgGroupConversation Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	Topic = "Take your wellness days and rest"
	Threads = @(
		@{
			Posts = @(
				@{
					Body = @{
						ContentType = "html"
						Content = "Contoso cares about you: Rest and Recharge"
					}
					NewParticipants = @(
						@{
							EmailAddress = @{
								Name = "Adele Vance"
								Address = "AdeleV@contoso.onmicrosoft.com"
							}
						}
					)
				}
			)
		}
	)
}
New-MgGroupConversation -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgGroupConversation Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
