### Example 1: Using the Update-MgBetaTeamChannel Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	DisplayName = "UpdateChannelModeration"
	Description = "Update channel moderation."
	ModerationSettings = @{
		UserNewMessageRestriction = "moderators"
		ReplyRestriction = "everyone"
		AllowNewMessageFromBots = $true
		AllowNewMessageFromConnectors = $true
	}
}
Update-MgBetaTeamChannel -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
