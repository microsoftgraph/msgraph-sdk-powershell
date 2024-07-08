### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	topic = "New head count"
	threads = @(
		@{
			posts = @(
				@{
					body = @{
						contentType = "html"
						content = "The confirmation will come by the end of the week."
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

New-MgBetaGroupConversation -GroupId $groupId -BodyParameter $params

```
This example shows how to use the New-MgBetaGroupConversation Cmdlet.

