### Example 1: Create a standard channel

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	displayName = "Architecture Discussion"
	description = "This channel is where we debate all future architecture plans"
	membershipType = "standard"
}

New-MgTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create a standard channel

### Example 2: Create private channel on behalf of user

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#Microsoft.Graph.channel"
	membershipType = "private"
	displayName = "My First Private Channel"
	description = "This is my first private channels"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"user@odata.bind" = "https://graph.microsoft.com/v1.0/users('62855810-484b-4823-9e01-60667f8b12ae')"
			roles = @(
				"owner"
			)
		}
	)
}

New-MgTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create private channel on behalf of user

### Example 3: Create a channel in migration mode

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"@microsoft.graph.channelCreationMode" = "migration"
	displayName = "Import_150958_99z"
	description = "Import_150958_99z"
	createdDateTime = [System.DateTime]::Parse("2020-03-14T11:22:17.067Z")
}

New-MgTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create a channel in migration mode

### Example 4: Create private channel on behalf of user using user principal name

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"@odata.type" = "#Microsoft.Graph.channel"
	membershipType = "private"
	displayName = "My First Private Channel"
	description = "This is my first private channels"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"user@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
			roles = @(
				"owner"
			)
		}
	)
}

New-MgTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create private channel on behalf of user using user principal name

### Example 5: Create a shared channel on behalf of a user

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	displayName = "My First Shared Channel"
	description = "This is my first shared channel"
	membershipType = "shared"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			"user@odata.bind" = "https://graph.microsoft.com/v1.0/users('7640023f-fe43-573f-9ff4-84a9efe4acd6')"
			roles = @(
				"owner"
			)
		}
	)
}

New-MgTeamChannel -TeamId $teamId -BodyParameter $params

```
This example will create a shared channel on behalf of a user

