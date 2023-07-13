### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	body = @{
		content = "Hello World"
	}
}

New-MgBetaTeamChannelMessage -TeamId $teamId -ChannelId $channelId -BodyParameter $params
```
This example shows how to use the New-MgBetaTeamChannelMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

