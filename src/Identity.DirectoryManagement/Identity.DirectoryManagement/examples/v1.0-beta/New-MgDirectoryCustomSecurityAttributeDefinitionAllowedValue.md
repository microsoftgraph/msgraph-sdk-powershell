### Example 1: Using the New-MgBetaDirectoryCustomSecurityAttributeDefinitionAllowedValue Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	Id = "Alpine"
	IsActive = "true"
}
New-MgBetaDirectoryCustomSecurityAttributeDefinitionAllowedValue -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryCustomSecurityAttributeDefinitionAllowedValue Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
