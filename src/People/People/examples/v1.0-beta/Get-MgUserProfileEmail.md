### Example 1: Using the Get-MgUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileEmail -UserId $userId
```
This example shows how to use the Get-MgUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.People
Get-MgUserProfileEmail -UserId $userId -ItemEmailId $itemEmailId
```
This example shows how to use the Get-MgUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
