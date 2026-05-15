### Example 1: Update a channel

```powershell

Import-Module Microsoft.Graph.Teams

Update-MgTeamChannel -TeamId $teamId -ChannelId $channelId

```
This example will update a channel

### Example 2: Update the layout type of a channel

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	layoutType = "chat"
}

Update-MgTeamChannel -TeamId $teamId -ChannelId $channelId -BodyParameter $params

```
This example will update the layout type of a channel

### Example 3: Switch a channel back to post layout type

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	layoutType = "post"
}

Update-MgTeamChannel -TeamId $teamId -ChannelId $channelId -BodyParameter $params

```
This example will switch a channel back to post layout type

