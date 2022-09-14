### Example 1
``` powershell
Import-Module Microsoft.Graph.SchemaExtensions
Get-MgSchemaExtension -SchemaExtensionId $schemaExtensionId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.SchemaExtensions
Get-MgSchemaExtension -Filter "id eq 'graphlearn_test'" 
```
