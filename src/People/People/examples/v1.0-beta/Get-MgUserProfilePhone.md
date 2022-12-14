### Example 1: Using the Get-MgBetaUserProfilePhone Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfilePhone -UserId $userId -ItemPhoneId $itemPhoneId
```
This example shows how to use the Get-MgBetaUserProfilePhone Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfilePhone Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfilePhone -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfilePhone Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
