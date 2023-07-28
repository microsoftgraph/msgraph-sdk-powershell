### Example 1: Add an existing user or group

```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/groups/{id}"
}

New-MgDirectoryAdministrativeUnitMemberByRef -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the New-MgDirectoryAdministrativeUnitMemberByRef Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

