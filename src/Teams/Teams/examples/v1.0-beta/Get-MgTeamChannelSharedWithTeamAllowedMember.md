### Example 1: Using the Get-MgBetaTeamChannelSharedWithTeamAllowedMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeamChannelSharedWithTeamAllowedMember -TeamId $teamId -ChannelId $channelId -SharedWithChannelTeamInfoId $sharedWithChannelTeamInfoId
```
This example shows how to use the Get-MgBetaTeamChannelSharedWithTeamAllowedMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
