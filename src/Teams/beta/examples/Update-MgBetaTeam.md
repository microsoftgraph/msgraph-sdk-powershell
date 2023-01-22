### Example 1: Using the Update-MgBetaTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	IsMembershipLimitedToOwners = $true
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
	DiscoverySettings = @{
		ShowInTeamsSearchAndSuggestions = $true
	}
}
Update-MgBetaTeam -TeamId $teamId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
