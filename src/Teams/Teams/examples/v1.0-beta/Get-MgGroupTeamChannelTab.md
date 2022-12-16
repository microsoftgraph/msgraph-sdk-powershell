### Example 1: List all the tabs in the channel along with associated Teams app

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp"
```
This example shows how to use the Get-MgGroupTeamChannelTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List all the tabs belonging to a specific app in a channel

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.planner'"
```
This example shows how to use the Get-MgGroupTeamChannelTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

