###Example 1
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	Id = "contoso.com"
}
New-MgDomain -BodyParameter $params
```
