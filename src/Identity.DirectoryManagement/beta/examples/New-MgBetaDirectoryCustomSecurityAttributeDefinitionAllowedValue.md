### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	id = "Alpine"
	isActive = "true"
}

New-MgBetaDirectoryCustomSecurityAttributeDefinitionAllowedValue -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryCustomSecurityAttributeDefinitionAllowedValue Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

