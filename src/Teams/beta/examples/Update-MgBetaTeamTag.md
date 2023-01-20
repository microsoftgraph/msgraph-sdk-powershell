### Example 1: Using the Update-MgBetaTeamTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	DisplayName = "Finance"
}
Update-MgBetaTeamTag -TeamId $teamId -TeamworkTagId $teamworkTagId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTeamTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
