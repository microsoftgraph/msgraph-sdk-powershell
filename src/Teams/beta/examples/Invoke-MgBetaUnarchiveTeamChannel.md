### Example 1: Unarchive a channel

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Invoke-MgBetaUnarchiveTeamChannel -TeamId $teamId -ChannelId $channelId

```
This example will unarchive a channel

### Example 2: Unarchive a channel when the team is archived

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Invoke-MgBetaUnarchiveTeamChannel -TeamId $teamId -ChannelId $channelId

```
This example will unarchive a channel when the team is archived

