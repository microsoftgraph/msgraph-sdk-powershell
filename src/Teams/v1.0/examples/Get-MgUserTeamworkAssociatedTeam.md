### Example 1: Using the Get-MgUserTeamworkAssociatedTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
# A UPN can also be used as -UserId.
Get-MgUserTeamworkAssociatedTeam -UserId $userId
```
This example shows how to use the Get-MgUserTeamworkAssociatedTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
