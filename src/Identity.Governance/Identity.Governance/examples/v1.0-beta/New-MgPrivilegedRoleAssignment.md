### Example 1: Using the New-MgBetaPrivilegedRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	UserId = "userId-value"
	RoleId = "roleId-value"
}
New-MgBetaPrivilegedRoleAssignment -BodyParameter $params
```
This example shows how to use the New-MgBetaPrivilegedRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
