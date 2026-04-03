### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "UpdateChannelModeration"
	description = "Update channel moderation."
	moderationSettings = @{
		userNewMessageRestriction = "moderators"
		replyRestriction = "everyone"
		allowNewMessageFromBots = $true
		allowNewMessageFromConnectors = $true
	}
}

Update-MgBetaTeamChannel -TeamId $teamId -ChannelId $channelId -BodyParameter $params

```
This example shows how to use the Update-MgBetaTeamChannel Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	layoutType = "chat"
}

Update-MgBetaTeamChannel -TeamId $teamId -ChannelId $channelId -BodyParameter $params

```
This example shows how to use the Update-MgBetaTeamChannel Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	layoutType = "post"
}

Update-MgBetaTeamChannel -TeamId $teamId -ChannelId $channelId -BodyParameter $params

```
This example shows how to use the Update-MgBetaTeamChannel Cmdlet.

