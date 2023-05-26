### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

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
This example shows how to use the Get-MgTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

