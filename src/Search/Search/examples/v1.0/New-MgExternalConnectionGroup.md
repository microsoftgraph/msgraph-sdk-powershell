### Example 1: Using the New-MgExternalConnectionGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	Id = "31bea3d537902000"
	DisplayName = "Contoso Marketing"
	Description = "The product marketing team"
}
New-MgExternalConnectionGroup -ExternalConnectionId $externalConnectionId -BodyParameter $params
```
This example shows how to use the New-MgExternalConnectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
