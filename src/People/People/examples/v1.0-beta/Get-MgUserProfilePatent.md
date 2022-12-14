### Example 1: Using the Get-MgBetaUserProfilePatent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfilePatent -UserId $userId -ItemPatentId $itemPatentId
```
This example shows how to use the Get-MgBetaUserProfilePatent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfilePatent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfilePatent -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfilePatent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
