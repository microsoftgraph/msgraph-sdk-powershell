### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

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

Update-MgBetaTeam -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

