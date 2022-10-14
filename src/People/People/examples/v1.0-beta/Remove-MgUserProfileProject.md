### Example 1: Using the Remove-MgUserProfileProject Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileProject -UserId $userId -ProjectParticipationId $projectParticipationId
```
This example shows how to use the Remove-MgUserProfileProject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
