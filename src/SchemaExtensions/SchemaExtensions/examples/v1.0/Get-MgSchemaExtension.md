### Example 1: Using the Get-MgSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.SchemaExtensions
Get-MgSchemaExtension -SchemaExtensionId $schemaExtensionId
```
This example shows how to use the Get-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.SchemaExtensions
Get-MgSchemaExtension -Filter "id eq 'graphlearn_test'" 
```
This example shows how to use the Get-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
