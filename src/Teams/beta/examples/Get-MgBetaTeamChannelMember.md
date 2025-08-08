### Example 1: List all members of a channel

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamChannelMember -TeamId $teamId -ChannelId $channelId

```
This example will list all members of a channel

### Example 2: Find a channel member using their Microsoft Entra user object ID

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamChannelMember -TeamId $teamId -ChannelId $channelId -Filter "(microsoft.graph.aadUserConversationMember/userId eq '73761f06-2ac9-469c-9f10-279a8cc267f9')" 

```
This example will find a channel member using their microsoft entra user object id

