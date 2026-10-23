### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	teamId = "9dda0ae1-e007-4a1d-81ec-2cf4b1274610"
	channelId = "19:eeaa4e946d674c4f8d4dded613780f45@thread.v2"
	messageId = "1580849738240"
}

Remove-MgBetaUserTeamworkTargetedMessage -UserId $userId -BodyParameter $params

```
This example shows how to use the Remove-MgBetaUserTeamworkTargetedMessage Cmdlet.

