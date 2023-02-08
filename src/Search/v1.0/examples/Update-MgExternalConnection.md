### Example 1: Using the Update-MgExternalConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	Name = "Contoso HR Service Tickets"
	Description = "Connection to index HR service tickets"
}
Update-MgExternalConnection -ExternalConnectionId $externalConnectionId -BodyParameter $params
```
This example shows how to use the Update-MgExternalConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
