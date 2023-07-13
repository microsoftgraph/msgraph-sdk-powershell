### Example 1: Using the Get-MgBetaUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileAccount -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileAccount -UserId $userId -UserAccountInformationId $userAccountInformationId
```
This example shows how to use the Get-MgBetaUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
