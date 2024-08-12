### Example 1: Create an extension in a new group post using POST operation

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
							extensionName = "Com.Contoso.Benefits"
							companyName = "Contoso"
							expirationDate = "2016-08-03T11:00:00.000Z"
							topPicks = @(
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
This example will create an extension in a new group post using post operation

