### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	isActive = "false"
}

Update-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -AllowedValueId $allowedValueId -BodyParameter $params

```
This example shows how to use the Update-MgDirectoryCustomSecurityAttributeDefinitionAllowedValue Cmdlet.

