### Example 1: Using the Get-MgUserScopedRoleMemberOf Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
# A UPN can also be used as -UserId.
Get-MgUserScopedRoleMemberOf -UserId $userId
```
This example shows how to use the Get-MgUserScopedRoleMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
