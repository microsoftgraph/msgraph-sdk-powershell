###Example 1
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	RoleTemplateId = "fe930be7-5e62-47db-91af-98c3a49a38b1"
}
New-MgDirectoryRole -BodyParameter $params
```
