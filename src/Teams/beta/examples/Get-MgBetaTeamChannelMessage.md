### Example 1: Get a message in a channel

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId
```
This example shows how to use the Get-MgBetaTeamChannelMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

