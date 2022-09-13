###Example 1
```
Import-Module Microsoft.Graph.Search
$params = @{
	DisplayName = "Contoso Marketing"
	Description = "The product marketing team"
}
Update-MgExternalConnectionGroup -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params
```
