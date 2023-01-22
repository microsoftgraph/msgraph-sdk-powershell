### Example 1: Using the New-MgBetaTeamChannel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@microsoft.graph.channelCreationMode" = "migration"
	DisplayName = "Import_150958_99z"
	Description = "Import_150958_99z"
	CreatedDateTime = [System.DateTime]::Parse("2020-03-14T11:22:17.067Z")
}
New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaTeamChannel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	DisplayName = "Architecture Discussion"
	Description = "This channel is where we debate all future architecture plans"
	MembershipType = "standard"
}
New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaTeamChannel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	DisplayName = "TestChannelModeration"
	Description = "Test channel moderation."
	MembershipType = "standard"
	ModerationSettings = @{
		UserNewMessageRestriction = "everyoneExceptGuests"
		ReplyRestriction = "everyone"
		AllowNewMessageFromBots = $true
		AllowNewMessageFromConnectors = $true
	}
}
New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgBetaTeamChannel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#Microsoft.Graph.channel"
	MembershipType = "private"
	DisplayName = "My First Private Channel"
	Description = "This is my first private channels"
	Members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"User@odata.bind" = "https://graph.microsoft.com/beta/users('jacob@contoso.com')"
			Roles = @(
				"owner"
			)
		}
	)
}
New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the New-MgBetaTeamChannel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	"@odata.type" = "#Microsoft.Graph.channel"
	MembershipType = "private"
	DisplayName = "My First Private Channel"
	Description = "This is my first private channels"
	Members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"User@odata.bind" = "https://graph.microsoft.com/beta/users('62855810-484b-4823-9e01-60667f8b12ae')"
			Roles = @(
				"owner"
			)
		}
	)
}
New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the New-MgBetaTeamChannel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	DisplayName = "My First Shared Channel"
	Description = "This is my first shared channel"
	MembershipType = "shared"
	Members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"User@odata.bind" = "https://graph.microsoft.com/beta/users('7640023f-fe43-gv3f-9gg4-84a9efe4acd6')"
			Roles = @(
				"owner"
			)
		}
	)
}
New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
