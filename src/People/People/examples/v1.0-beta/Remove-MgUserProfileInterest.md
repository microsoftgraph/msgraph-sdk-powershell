### Example 1: Using the Remove-MgBetaUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileInterest -UserId $userId -PersonInterestId $personInterestId
```
This example shows how to use the Remove-MgBetaUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
