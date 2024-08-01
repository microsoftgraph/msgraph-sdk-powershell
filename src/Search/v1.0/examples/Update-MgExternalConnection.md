### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Search

$params = @{
	name = "Contoso HR Service Tickets"
	description = "Connection to index HR service tickets"
}

Update-MgExternalConnection -ExternalConnectionId $externalConnectionId -BodyParameter $params

```
This example shows how to use the Update-MgExternalConnection Cmdlet.

