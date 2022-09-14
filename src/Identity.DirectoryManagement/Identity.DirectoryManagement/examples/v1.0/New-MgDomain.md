### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	Id = "contoso.com"
}
New-MgDomain -BodyParameter $params
```
