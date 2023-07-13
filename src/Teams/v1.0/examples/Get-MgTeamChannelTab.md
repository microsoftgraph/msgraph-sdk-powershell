### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -TeamsTabId $teamsTabId -ExpandProperty "teamsApp"
```
This example shows how to use the Get-MgTeamChannelTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

