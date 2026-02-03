### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	name = "Contoso HR Service Tickets"
	description = "Connection to index HR service tickets"
}

Update-MgBetaExternalConnection -ExternalConnectionId $externalConnectionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaExternalConnection Cmdlet.

