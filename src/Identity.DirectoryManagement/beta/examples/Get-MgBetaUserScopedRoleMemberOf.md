### Example 1: Using the Get-MgBetaUserScopedRoleMemberOf Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
# A UPN can also be used as -UserId.
Get-MgBetaUserScopedRoleMemberOf -UserId $userId
```
This example shows how to use the Get-MgBetaUserScopedRoleMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
