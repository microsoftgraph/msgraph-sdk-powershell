### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Greater Seattle District Technical Schools"
}

Update-MgBetaDirectoryAdministrativeUnit -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDirectoryAdministrativeUnit Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

