### Example 1: Using the Get-MgUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileAccount -UserId $userId
```
This example shows how to use the Get-MgUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileAccount -UserId $userId -UserAccountInformationId $userAccountInformationId
```
This example shows how to use the Get-MgUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
