### Example 1: Update a custom security attribute

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	description = "Target completion date (YYYY/MM/DD)"
}

Update-MgBetaDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -BodyParameter $params

```
This example will update a custom security attribute

### Example 2: Update the predefined values for a custom security attribute

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"allowedValues@delta" = @(
	)
}

Update-MgBetaDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -BodyParameter $params

```
This example will update the predefined values for a custom security attribute

### Example 3: Deactivate a custom security attribute

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	status = "Deprecated"
}

Update-MgBetaDirectoryCustomSecurityAttributeDefinition -CustomSecurityAttributeDefinitionId $customSecurityAttributeDefinitionId -BodyParameter $params

```
This example will deactivate a custom security attribute

