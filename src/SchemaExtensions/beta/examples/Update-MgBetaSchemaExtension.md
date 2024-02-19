### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.SchemaExtensions

$params = @{
	owner = "ef4cb9a8-97c3-4ca7-854b-5cb5ced376fa"
	properties = @(
		@{
			name = "courseId"
			type = "Integer"
		}
		@{
			name = "courseName"
			type = "String"
		}
		@{
			name = "courseType"
			type = "String"
		}
		@{
			name = "courseSupervisors"
			type = "String"
		}
	)
}

Update-MgBetaSchemaExtension -SchemaExtensionId $schemaExtensionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSchemaExtension Cmdlet.

