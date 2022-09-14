### Example 1: Using the Update-MgDirectoryAdministrativeUnit Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	DisplayName = "Greater Seattle District Technical Schools"
}
Update-MgDirectoryAdministrativeUnit -AdministrativeUnitId $administrativeUnitId -BodyParameter $params
```
This example shows how to use the Update-MgDirectoryAdministrativeUnit Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
