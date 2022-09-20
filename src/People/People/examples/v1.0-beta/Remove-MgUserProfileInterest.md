### Example 1: Using the Remove-MgUserProfileInterest Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileInterest -UserId $userId -PersonInterestId $personInterestId
```
This example shows how to use the Remove-MgUserProfileInterest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
