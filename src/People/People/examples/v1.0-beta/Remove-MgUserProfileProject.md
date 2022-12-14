### Example 1: Using the Remove-MgBetaUserProfileProject Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileProject -UserId $userId -ProjectParticipationId $projectParticipationId
```
This example shows how to use the Remove-MgBetaUserProfileProject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
