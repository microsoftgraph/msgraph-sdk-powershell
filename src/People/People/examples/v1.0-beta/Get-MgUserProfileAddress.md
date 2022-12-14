### Example 1: Using the Get-MgBetaUserProfileAddress Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileAddress -UserId $userId -ItemAddressId $itemAddressId
```
This example shows how to use the Get-MgBetaUserProfileAddress Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileAddress Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileAddress -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileAddress Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
