### Example 1: Start the migration on an existing channel with a specific timestamp

```powershell

Import-Module Microsoft.Graph.Teams

Start-MgTeamChannelMigration -TeamId $teamId -ChannelId $channelId

```
This example will start the migration on an existing channel with a specific timestamp

### Example 2: Start the migration when a channel is already in migration mode

```powershell

Import-Module Microsoft.Graph.Teams

Start-MgTeamChannelMigration -TeamId $teamId -ChannelId $channelId

```
This example will start the migration when a channel is already in migration mode

