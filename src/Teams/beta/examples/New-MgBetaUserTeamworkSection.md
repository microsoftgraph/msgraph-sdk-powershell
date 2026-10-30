### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "Project Alpha"
	displayIcon = @{
		iconType = "🚀"
	}
	sortType = "mostRecent"
}

New-MgBetaUserTeamworkSection -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserTeamworkSection Cmdlet.

