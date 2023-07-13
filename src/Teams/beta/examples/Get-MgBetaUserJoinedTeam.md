### Example 1: Using the Get-MgBetaUserJoinedTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
# A UPN can also be used as -UserId.
Get-MgBetaUserJoinedTeam -UserId $userId
```
This example shows how to use the Get-MgBetaUserJoinedTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
