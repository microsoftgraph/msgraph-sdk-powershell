### Example 1: Using the Get-MgUserProfileAddress Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileAddress -UserId $userId -ItemAddressId $itemAddressId
```
This example shows how to use the Get-MgUserProfileAddress Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileAddress Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileAddress -UserId $userId
```
This example shows how to use the Get-MgUserProfileAddress Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
