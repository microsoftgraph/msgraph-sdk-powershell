### Example 1: Get manager

```powershell
Import-Module Microsoft.Graph.Beta.Users

Get-MgBetaUserManager -UserId $userId
```
This example shows how to use the Remove-MgBetaUserManagerByRef Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get manager chain up to the root level

```powershell
Import-Module Microsoft.Graph.Beta.Users

# A UPN can also be used as -UserId.
Get-MgBetaUser -UserId $userId -ExpandProperty "manager(`$levels=max;`$select=id,displayName)" -Property "id,displayName" -CountVariable CountVar -ConsistencyLevel eventual
```
This example shows how to use the Remove-MgBetaUserManagerByRef Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

