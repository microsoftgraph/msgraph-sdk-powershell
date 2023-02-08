### Example 1: Using the New-MgBetaSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.SchemaExtensions
$params = @{
	Id = "graphlearn_courses"
	Description = "Graph Learn training courses extensions"
	TargetTypes = @(
		"Group"
	)
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
	)
}
New-MgBetaSchemaExtension -BodyParameter $params
```
This example shows how to use the New-MgBetaSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.SchemaExtensions
$params = @{
	Id = "courses"
	Description = "Graph Learn training courses extensions"
	TargetTypes = @(
		"Group"
	)
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
	)
}
New-MgBetaSchemaExtension -BodyParameter $params
```
This example shows how to use the New-MgBetaSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.SchemaExtensions
$params = @{
	Id = "courses"
	Description = "Graph Learn training courses extensions"
	TargetTypes = @(
		"Group"
	)
	Owner = "50897f70-a455-4adf-87bc-4cf17091d5ac"
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
	)
}
New-MgBetaSchemaExtension -BodyParameter $params
```
This example shows how to use the New-MgBetaSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
