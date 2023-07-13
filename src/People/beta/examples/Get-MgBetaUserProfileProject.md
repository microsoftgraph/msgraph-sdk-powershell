### Example 1: Using the Get-MgBetaUserProfileProject Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileProject -UserId $userId -ProjectParticipationId $projectParticipationId
```
This example shows how to use the Get-MgBetaUserProfileProject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileProject Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileProject -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileProject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
