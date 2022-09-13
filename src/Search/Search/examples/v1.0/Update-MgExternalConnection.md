###Example 1
```
Import-Module Microsoft.Graph.Search
$params = @{
	Name = "Contoso HR Service Tickets"
	Description = "Connection to index HR service tickets"
}
Update-MgExternalConnection -ExternalConnectionId $externalConnectionId -BodyParameter $params
```
