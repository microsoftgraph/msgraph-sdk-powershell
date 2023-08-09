### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Search

$params = @{
	id = "31bea3d537902000"
	displayName = "Contoso Marketing"
	description = "The product marketing team"
}

New-MgExternalConnectionGroup -ExternalConnectionId $externalConnectionId -BodyParameter $params

```
This example shows how to use the New-MgExternalConnectionGroup Cmdlet.

