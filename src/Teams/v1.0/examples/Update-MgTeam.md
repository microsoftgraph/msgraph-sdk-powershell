### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	memberSettings = @{
		allowCreateUpdateChannels = $true
	}
	messagingSettings = @{
		allowUserEditMessages = $true
		allowUserDeleteMessages = $true
	}
	funSettings = @{
		allowGiphy = $true
		giphyContentRating = "strict"
	}
}

Update-MgTeam -TeamId $teamId -BodyParameter $params

```
This example shows how to use the Update-MgTeam Cmdlet.

