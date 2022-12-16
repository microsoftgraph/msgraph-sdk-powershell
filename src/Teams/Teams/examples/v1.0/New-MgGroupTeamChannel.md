### Example 1: List all channels

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannel -TeamId $teamId
```
This example shows how to use the New-MgGroupTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List all private channels

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannel -TeamId $teamId -Filter "membershipType eq 'private'"
```
This example shows how to use the New-MgGroupTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: List all shared channels

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamChannel -TeamId $teamId -Filter "membershipType eq 'shared'"
```
This example shows how to use the New-MgGroupTeamChannel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

