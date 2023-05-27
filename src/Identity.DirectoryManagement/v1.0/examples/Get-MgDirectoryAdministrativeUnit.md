### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	displayName = "Greater Seattle District Technical Schools"
}

Update-MgDirectoryAdministrativeUnit -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the Get-MgDirectoryAdministrativeUnit Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

