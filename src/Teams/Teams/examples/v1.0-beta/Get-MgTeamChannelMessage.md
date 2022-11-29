### Example 1: Using the Get-MgTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId
```
This example shows how to use the Get-MgTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -Top 3 
```
This example shows how to use the Get-MgTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
