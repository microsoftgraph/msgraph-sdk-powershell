### Example 1: Using the New-MgDirectoryRole Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	RoleTemplateId = "fe930be7-5e62-47db-91af-98c3a49a38b1"
}
New-MgDirectoryRole -BodyParameter $params
```
This example shows how to use the New-MgDirectoryRole Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
