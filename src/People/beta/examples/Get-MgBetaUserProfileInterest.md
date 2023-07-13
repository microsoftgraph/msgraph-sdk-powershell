### Example 1: Using the Get-MgBetaUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileInterest -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileInterest -UserId $userId -PersonInterestId $personInterestId
```
This example shows how to use the Get-MgBetaUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
