### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
# A UPN can also be used as -UserId.
Get-MgUserJoinedTeam -UserId $userId
```
