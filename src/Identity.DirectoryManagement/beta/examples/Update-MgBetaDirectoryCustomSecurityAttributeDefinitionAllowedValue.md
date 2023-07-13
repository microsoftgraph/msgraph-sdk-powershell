### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	isActive = "false"
}

Update-MgBetaDirectoryCustomSecurityAttributeDefinitionAllowedValue -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -AllowedValueId $allowedValueId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDirectoryCustomSecurityAttributeDefinitionAllowedValue Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

