### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	roleId = "roleId-value"
	roleMemberInfo = @{
		id = "id-value"
	}
}

New-MgBetaAdministrativeUnitScopedRoleMember -AdministrativeUnitId $administrativeUnitId -BodyParameter $params

```
This example shows how to use the New-MgBetaAdministrativeUnitScopedRoleMember Cmdlet.

