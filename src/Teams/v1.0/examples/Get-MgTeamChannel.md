### Example 1: List all channels

```powershellImport-Module Microsoft.Graph.Teams

Get-MgAllTeamChannel -TeamId $teamId
```
This example shows how to use the Get-MgTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List all shared channels

```powershellImport-Module Microsoft.Graph.Teams

Get-MgAllTeamChannel -TeamId $teamId -Filter "membershipType eq 'shared'"
```
This example shows how to use the Get-MgTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

