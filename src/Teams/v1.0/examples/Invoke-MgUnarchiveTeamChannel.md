### Example 1: Unarchive a channel

```powershell

Import-Module Microsoft.Graph.Teams

Invoke-MgUnarchiveTeamChannel -TeamId $teamId -ChannelId $channelId

```
This example will unarchive a channel

### Example 2: Unarchive a channel when the team is archived

```powershell

Import-Module Microsoft.Graph.Teams

Invoke-MgUnarchiveTeamChannel -TeamId $teamId -ChannelId $channelId

```
This example will unarchive a channel when the team is archived

