### Example 1: Using the New-MgBetaAdministrativeUnitScopedRoleMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	RoleId = "roleId-value"
	RoleMemberInfo = @{
		Id = "id-value"
	}
}
New-MgBetaAdministrativeUnitScopedRoleMember -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the New-MgBetaAdministrativeUnitScopedRoleMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
