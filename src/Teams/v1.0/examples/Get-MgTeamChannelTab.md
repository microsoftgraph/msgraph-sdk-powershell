### Example 1: List all the tabs in the channel along with associated Teams app

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp" 

```
This example will list all the tabs in the channel along with associated teams app

### Example 2: List all the tabs belonging to a specific app in a channel

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.planner'" 

```
This example will list all the tabs belonging to a specific app in a channel

