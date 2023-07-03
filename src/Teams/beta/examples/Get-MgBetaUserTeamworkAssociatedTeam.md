### Example 1: Using the Get-MgBetaUserTeamworkAssociatedTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
# A UPN can also be used as -UserId.
Get-MgBetaUserTeamworkAssociatedTeam -UserId $userId
```
This example shows how to use the Get-MgBetaUserTeamworkAssociatedTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
