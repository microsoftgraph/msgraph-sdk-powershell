### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	memberSettings = @{
		allowCreatePrivateChannels = $true
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

Set-MgGroupTeam -GroupId $groupId -BodyParameter $params

```
This example shows how to use the Set-MgGroupTeam Cmdlet.

