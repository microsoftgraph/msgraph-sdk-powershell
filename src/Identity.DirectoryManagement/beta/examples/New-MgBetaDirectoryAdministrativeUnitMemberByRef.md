### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/groups/{id}"
}

New-MgBetaDirectoryAdministrativeUnitMemberByRef -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryAdministrativeUnitMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

