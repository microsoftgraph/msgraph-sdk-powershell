### Example 1
``` powershell
Import-Module Microsoft.Graph.Search
$params = @{
	DisplayName = "Contoso Marketing"
	Description = "The product marketing team"
}
Update-MgExternalConnectionGroup -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params
```
