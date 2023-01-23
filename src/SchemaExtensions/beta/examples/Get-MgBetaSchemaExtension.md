### Example 1: Using the Get-MgBetaSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.SchemaExtensions
Get-MgBetaSchemaExtension -SchemaExtensionId $schemaExtensionId
```
This example shows how to use the Get-MgBetaSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.SchemaExtensions
Get-MgBetaSchemaExtension -Filter "id eq 'graphlearn_test'" 
```
This example shows how to use the Get-MgBetaSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
