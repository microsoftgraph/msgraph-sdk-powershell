###Example 1
```
Import-Module Microsoft.Graph.Search
$params = @{
	Id = "contosohr"
	Name = "Contoso HR"
	Description = "Connection to index Contoso HR system"
}
New-MgExternalConnection -BodyParameter $params
```
