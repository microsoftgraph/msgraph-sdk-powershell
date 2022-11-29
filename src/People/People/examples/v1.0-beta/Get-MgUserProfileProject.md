### Example 1: Using the Get-MgUserProfileProject Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileProject -UserId $userId -ProjectParticipationId $projectParticipationId
```
This example shows how to use the Get-MgUserProfileProject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileProject Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileProject -UserId $userId
```
This example shows how to use the Get-MgUserProfileProject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
