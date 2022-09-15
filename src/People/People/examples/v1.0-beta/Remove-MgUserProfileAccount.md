### Example 1: Using the Remove-MgUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileAccount -UserId $userId -UserAccountInformationId $userAccountInformationId
```
This example shows how to use the Remove-MgUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
