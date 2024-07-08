### Example 1: Archive a channel

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Invoke-MgBetaArchiveTeamChannel -TeamId $teamId -ChannelId $channelId

```
This example will archive a channel

### Example 2: Archive a channel when the team is archived

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Invoke-MgBetaArchiveTeamChannel -TeamId $teamId -ChannelId $channelId

```
This example will archive a channel when the team is archived

