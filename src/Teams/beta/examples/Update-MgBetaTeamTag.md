### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "Finance"
}

Update-MgBetaTeamTag -TeamId $teamId -TeamworkTagId $teamworkTagId -BodyParameter $params

```
This example shows how to use the Update-MgBetaTeamTag Cmdlet.

