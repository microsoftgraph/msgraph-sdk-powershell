### Example 1: Create a standard channel

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "Architecture Discussion"
	description = "This channel is where we debate all future architecture plans"
	membershipType = "standard"
}

New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create a standard channel

### Example 2: Create private channel on behalf of user

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#Microsoft.Graph.channel"
	membershipType = "private"
	displayName = "My First Private Channel"
	description = "This is my first private channels"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('62855810-484b-4823-9e01-60667f8b12ae')"
			roles = @(
				"owner"
			)
		}
	)
}

New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create private channel on behalf of user

### Example 3: Create a channel in migration mode

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@microsoft.graph.channelCreationMode" = "migration"
	displayName = "Import_150958_99z"
	description = "Import_150958_99z"
	createdDateTime = [System.DateTime]::Parse("2020-03-14T11:22:17.067Z")
}

New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create a channel in migration mode

### Example 4: Create standard channel with moderation settings

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "TestChannelModeration"
	description = "Test channel moderation."
	membershipType = "standard"
	moderationSettings = @{
		userNewMessageRestriction = "everyoneExceptGuests"
		replyRestriction = "everyone"
		allowNewMessageFromBots = $true
		allowNewMessageFromConnectors = $true
	}
}

New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create standard channel with moderation settings

### Example 5: Create private channel on behalf of user using user principal name

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	"@odata.type" = "#Microsoft.Graph.channel"
	membershipType = "private"
	displayName = "My First Private Channel"
	description = "This is my first private channels"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('jacob@contoso.com')"
			roles = @(
				"owner"
			)
		}
	)
}

New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create private channel on behalf of user using user principal name

### Example 6: Create a shared channel on behalf of a user

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "My First Shared Channel"
	description = "This is my first shared channel"
	membershipType = "shared"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"user@odata.bind" = "https://graph.microsoft.com/beta/users('7640023f-fe43-gv3f-9gg4-84a9efe4acd6')"
			roles = @(
				"owner"
			)
		}
	)
}

New-MgBetaTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create a shared channel on behalf of a user

