### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -Top 3
```
This example shows how to use the New-MgGroupTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -Top 1 -ExpandProperty "replies"
```
This example shows how to use the New-MgGroupTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

