### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

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

Update-MgBetaTeam -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaTeam Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

