### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	DisplayName = "Seattle District Technical Schools"
	Description = "Seattle district technical schools administration"
	Visibility = "HiddenMembership"
}
New-MgDirectoryAdministrativeUnit -BodyParameter $params
```
