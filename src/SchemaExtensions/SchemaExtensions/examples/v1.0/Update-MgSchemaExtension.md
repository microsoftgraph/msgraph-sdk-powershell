### Example 1: Using the Update-MgSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.SchemaExtensions
$params = @{
	Owner = "ef4cb9a8-97c3-4ca7-854b-5cb5ced376fa"
	Properties = @(
		@{
			Name = "courseId"
			Type = "Integer"
		}
		@{
			Name = "courseName"
			Type = "String"
		}
		@{
			Name = "courseType"
			Type = "String"
		}
		@{
			Name = "courseSupervisors"
			Type = "String"
		}
	)
}
Update-MgSchemaExtension -SchemaExtensionId $schemaExtensionId -BodyParameter $params
```
This example shows how to use the Update-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.SchemaExtensions
$params = @{
	Owner = "ef4cb9a8-97c3-4ca7-854b-5cb5ced376fa"
	Properties = @(
		@{
			Name = "courseId"
			Type = "Integer"
		}
		@{
			Name = "courseName"
			Type = "String"
		}
		@{
			Name = "courseType"
			Type = "String"
		}
		@{
			Name = "courseSupervisors"
			Type = "String"
		}
	)
}
Update-MgSchemaExtension -SchemaExtensionId $schemaExtensionId -BodyParameter $params
```
This example shows how to use the Update-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
