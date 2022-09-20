### Example 1: Using the Update-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	IsActive = "false"
}
Update-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -AllowedValueId $allowedValueId -BodyParameter $params
```
This example shows how to use the Update-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
