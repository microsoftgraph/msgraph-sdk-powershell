### Example 1: Using the Get-MgTeamChannelSharedWithTeamAllowedMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelSharedWithTeamAllowedMember -TeamId $teamId -ChannelId $channelId -SharedWithChannelTeamInfoId $sharedWithChannelTeamInfoId
```
This example shows how to use the Get-MgTeamChannelSharedWithTeamAllowedMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
