### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	displayName = "Finance"
}

Update-MgTeamTag -TeamId $teamId -TeamworkTagId $teamworkTagId -BodyParameter $params
```
This example shows how to use the Update-MgTeamTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

