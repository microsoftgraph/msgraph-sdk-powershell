### Example 1: Using the Get-MgBetaUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileEmail -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
Get-MgBetaUserProfileEmail -UserId $userId -ItemEmailId $itemEmailId
```
This example shows how to use the Get-MgBetaUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
