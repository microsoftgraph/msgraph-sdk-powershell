### Example 1: Using the Get-MgUserJoinedTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
# A UPN can also be used as -UserId.
Get-MgUserJoinedTeam -UserId $userId
```
This example shows how to use the Get-MgUserJoinedTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
