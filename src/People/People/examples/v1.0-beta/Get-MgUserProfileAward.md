### Example 1: Using the Get-MgUserProfileAward Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileAward -UserId $userId
```
This example shows how to use the Get-MgUserProfileAward Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileAward Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileAward -UserId $userId -PersonAwardId $personAwardId
```
This example shows how to use the Get-MgUserProfileAward Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
