### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Search

$params = @{
	id = "31bea3d537902000"
	displayName = "Contoso Marketing"
	description = "The product marketing team"
}

New-MgBetaExternalConnectionGroup -ExternalConnectionId $externalConnectionId -BodyParameter $params
```
This example shows how to use the New-MgBetaExternalConnectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

