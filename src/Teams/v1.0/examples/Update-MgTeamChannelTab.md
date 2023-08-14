### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	displayName = "My Contoso Tab - updated"
}

Update-MgTeamChannelTab -TeamId $teamId -ChannelId $channelId -TeamsTabId $teamsTabId -BodyParameter $params

```
This example shows how to use the Update-MgTeamChannelTab Cmdlet.

