### Example 1: Using the New-MgPrivilegedRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	UserId = "userId-value"
	RoleId = "roleId-value"
}
New-MgPrivilegedRoleAssignment -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
