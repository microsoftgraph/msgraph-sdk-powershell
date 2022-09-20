### Example 1: Using the Get-MgUserProfilePatent Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfilePatent -UserId $userId -ItemPatentId $itemPatentId
```
This example shows how to use the Get-MgUserProfilePatent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfilePatent Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfilePatent -UserId $userId
```
This example shows how to use the Get-MgUserProfilePatent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
