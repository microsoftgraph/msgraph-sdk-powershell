### Example 1: Using the Update-MgExternalConnectionGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	DisplayName = "Contoso Marketing"
	Description = "The product marketing team"
}
Update-MgExternalConnectionGroup -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params
```
This example shows how to use the Update-MgExternalConnectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
