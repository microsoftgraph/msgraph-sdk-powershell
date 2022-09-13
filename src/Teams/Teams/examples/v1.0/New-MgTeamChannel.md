###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"@microsoft.graph.channelCreationMode" = "migration"
	DisplayName = "Import_150958_99z"
	Description = "Import_150958_99z"
	CreatedDateTime = [System.DateTime]::Parse("2020-03-14T11:22:17.067Z")
}
New-MgTeamChannel -TeamId $teamId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "Architecture Discussion"
	Description = "This channel is where we debate all future architecture plans"
	MembershipType = "standard"
}
New-MgTeamChannel -TeamId $teamId -BodyParameter $params
```
###Example 3
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#Microsoft.Graph.channel"
	MembershipType = "private"
	DisplayName = "My First Private Channel"
	Description = "This is my first private channels"
	Members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('62855810-484b-4823-9e01-60667f8b12ae')"
			Roles = @(
				"owner"
			)
		}
	)
}
New-MgTeamChannel -TeamId $teamId -BodyParameter $params
```
###Example 4
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"@odata.type" = "#Microsoft.Graph.channel"
	MembershipType = "private"
	DisplayName = "My First Private Channel"
	Description = "This is my first private channels"
	Members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
			Roles = @(
				"owner"
			)
		}
	)
}
New-MgTeamChannel -TeamId $teamId -BodyParameter $params
```
###Example 5
```
Import-Module Microsoft.Graph.Teams
$params = @{
	DisplayName = "My First Shared Channel"
	Description = "This is my first shared channel"
	MembershipType = "shared"
	Members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('7640023f-fe43-573f-9ff4-84a9efe4acd6')"
			Roles = @(
				"owner"
			)
		}
	)
}
New-MgTeamChannel -TeamId $teamId -BodyParameter $params
```
