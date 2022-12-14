### Example 1: Using the Update-MgBetaExternalConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	Name = "Contoso HR Service Tickets"
	Description = "Connection to index HR service tickets"
}
Update-MgBetaExternalConnection -ExternalConnectionId $externalConnectionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaExternalConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
