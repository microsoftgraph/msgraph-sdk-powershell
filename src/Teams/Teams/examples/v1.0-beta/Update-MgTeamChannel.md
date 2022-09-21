### Example 1: Using the Update-MgTeamChannel Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
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
Update-MgTeamChannel -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the Update-MgTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
