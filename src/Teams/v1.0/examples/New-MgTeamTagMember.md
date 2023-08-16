### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Teams

$params = @{
	userId = "97f62344-57dc-409c-88ad-c4af14158ff5"
}

New-MgTeamTagMember -TeamId $teamId -TeamworkTagId $teamworkTagId -BodyParameter $params
```
This example shows how to use the New-MgTeamTagMember Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

