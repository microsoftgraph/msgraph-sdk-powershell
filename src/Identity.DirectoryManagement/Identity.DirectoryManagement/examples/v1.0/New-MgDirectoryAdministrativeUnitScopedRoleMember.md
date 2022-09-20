### Example 1: Using the New-MgDirectoryAdministrativeUnitScopedRoleMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	RoleId = "roleId-value"
	RoleMemberInfo = @{
		Id = "id-value"
	}
}
New-MgDirectoryAdministrativeUnitScopedRoleMember -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the New-MgDirectoryAdministrativeUnitScopedRoleMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
