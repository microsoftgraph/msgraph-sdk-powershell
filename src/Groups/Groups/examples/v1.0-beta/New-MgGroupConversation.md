### Example 1: Using the New-MgGroupConversation Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	Topic = "New head count"
	Threads = @(
		@{
			Posts = @(
				@{
					Body = @{
						ContentType = "html"
						Content = "The confirmation will come by the end of the week."
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
### Example 2: Using the New-MgGroupConversation Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	Topic = "Does anyone have a second?"
	Threads = @(
		@{
			Posts = @(
				@{
					Body = @{
						ContentType = "HTML"
						Content = "This is urgent!"
					}
					Extensions = @(
						@{
							"@odata.type" = "microsoft.graph.openTypeExtension"
							ExtensionName = "Com.Contoso.Benefits"
							CompanyName = "Contoso"
							ExpirationDate = "2016-08-03T11:00:00.000Z"
							TopPicks = @(
								"Employees only"
								"Add spouse or guest"
								"Add family"
							)
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
