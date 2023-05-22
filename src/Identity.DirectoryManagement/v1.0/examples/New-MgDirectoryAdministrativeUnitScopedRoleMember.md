### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	roleId = "roleId-value"
	roleMemberInfo = @{
		id = "id-value"
	}
}

New-MgDirectoryAdministrativeUnitScopedRoleMember -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the New-MgDirectoryAdministrativeUnitScopedRoleMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

