### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users

Get-MgUserMemberOf -UserId $userId
```
This example shows how to use the Get-MgUserMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Users

Get-MgUserMemberOfAsGroup -UserId $userId -Filter "appRoleAssignments/`$count gt 0" -Property "id,displayName"
```
This example shows how to use the Get-MgUserMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

