### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	topic = "Take your wellness days and rest"
	threads = @(
		@{
			posts = @(
				@{
					body = @{
						contentType = "html"
						content = "Contoso cares about you: Rest and Recharge"
					}
					newParticipants = @(
						@{
							emailAddress = @{
								name = "Adele Vance"
								address = "AdeleV@contoso.com"
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

