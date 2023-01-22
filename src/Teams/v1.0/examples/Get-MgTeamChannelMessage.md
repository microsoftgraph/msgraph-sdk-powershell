### Example 1: Using the Get-MgTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMessage -TeamId $teamId -Filter "lastModifiedDateTime gt 2019-11-01T00:00:00Z and lastModifiedDateTime lt 2021-11-01T00:00:00Z" 
```
This example shows how to use the Get-MgTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -ChatMessageId $chatMessageId
```
This example shows how to use the Get-MgTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgTeamChannelMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -Top 3 
```
This example shows how to use the Get-MgTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
