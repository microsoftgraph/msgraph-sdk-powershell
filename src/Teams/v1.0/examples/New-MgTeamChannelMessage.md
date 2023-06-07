### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	body = @{
		content = "Hello World"
	}
}

New-MgTeamChannelMessage -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the New-MgTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

