### Example 1: Using the Get-MgUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileInterest -UserId $userId
```
This example shows how to use the Get-MgUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileInterest -UserId $userId -PersonInterestId $personInterestId
```
This example shows how to use the Get-MgUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
