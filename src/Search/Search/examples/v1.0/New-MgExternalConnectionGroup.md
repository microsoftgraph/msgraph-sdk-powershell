###Example 1
```
Import-Module Microsoft.Graph.Search
$params = @{
	Id = "31bea3d537902000"
	DisplayName = "Contoso Marketing"
	Description = "The product marketing team"
}
New-MgExternalConnectionGroup -ExternalConnectionId $externalConnectionId -BodyParameter $params
```
