### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Search

$params = @{
	displayName = "Contoso Marketing"
	description = "The product marketing team"
}

Update-MgBetaExternalConnectionGroup -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params
```
This example shows how to use the Update-MgBetaExternalConnectionGroup Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

