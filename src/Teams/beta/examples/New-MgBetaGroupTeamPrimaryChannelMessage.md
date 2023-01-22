### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -Top 3
```
This example shows how to use the New-MgBetaGroupTeamPrimaryChannelMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -Top 1 -ExpandProperty "replies"
```
This example shows how to use the New-MgBetaGroupTeamPrimaryChannelMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

