### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	MemberSettings = @{
		AllowCreateUpdateChannels = $true
	}
	MessagingSettings = @{
		AllowUserEditMessages = $true
		AllowUserDeleteMessages = $true
	}
	FunSettings = @{
		AllowGiphy = $true
		GiphyContentRating = "strict"
	}
}

Update-MgTeam -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Remove-MgTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

