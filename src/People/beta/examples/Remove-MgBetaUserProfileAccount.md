### Example 1: Using the Remove-MgBetaUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileAccount -UserId $userId -UserAccountInformationId $userAccountInformationId
```
This example shows how to use the Remove-MgBetaUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
