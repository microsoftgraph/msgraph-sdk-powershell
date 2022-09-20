### Example 1: Using the Get-MgTeamChannelSharedWithTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelSharedWithTeam -TeamId $teamId -ChannelId $channelId -SharedWithChannelTeamInfoId $sharedWithChannelTeamInfoId
```
This example shows how to use the Get-MgTeamChannelSharedWithTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgTeamChannelSharedWithTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelSharedWithTeam -TeamId $teamId -ChannelId $channelId
```
This example shows how to use the Get-MgTeamChannelSharedWithTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
