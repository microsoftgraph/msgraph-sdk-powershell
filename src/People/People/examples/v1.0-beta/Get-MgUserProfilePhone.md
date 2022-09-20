### Example 1: Using the Get-MgUserProfilePhone Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfilePhone -UserId $userId -ItemPhoneId $itemPhoneId
```
This example shows how to use the Get-MgUserProfilePhone Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfilePhone Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfilePhone -UserId $userId
```
This example shows how to use the Get-MgUserProfilePhone Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
