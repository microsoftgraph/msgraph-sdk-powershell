### Example 1: Using the New-MgDirectoryAdministrativeUnit Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	DisplayName = "Seattle District Technical Schools"
	Description = "Seattle district technical schools administration"
	Visibility = "HiddenMembership"
}
New-MgDirectoryAdministrativeUnit -BodyParameter $params
```
This example shows how to use the New-MgDirectoryAdministrativeUnit Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
