###Example 1
```
Import-Module Microsoft.Graph.SchemaExtensions
Get-MgSchemaExtension -SchemaExtensionId $schemaExtensionId
```
###Example 2
```
Import-Module Microsoft.Graph.SchemaExtensions
Get-MgSchemaExtension -Filter "id eq 'graphlearn_test'" 
```
