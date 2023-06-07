### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Groups

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
								address = "AdeleV@contoso.onmicrosoft.com"
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
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

