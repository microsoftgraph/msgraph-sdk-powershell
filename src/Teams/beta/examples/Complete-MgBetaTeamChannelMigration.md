### Example 1: Complete the migration when a channel is in migration mode

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Complete-MgBetaTeamChannelMigration -TeamId $teamId -ChannelId $channelId

```
This example will complete the migration when a channel is in migration mode

### Example 2: Complete the migration when a channel isn't in migration mode

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Complete-MgBetaTeamChannelMigration -TeamId $teamId -ChannelId $channelId

```
This example will complete the migration when a channel isn't in migration mode

