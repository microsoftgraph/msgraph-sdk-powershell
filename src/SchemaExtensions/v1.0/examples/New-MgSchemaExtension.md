### Example 1: Creating a schema extension using a verified domain

```powershellImport-Module Microsoft.Graph.SchemaExtensions

$params = @{
	id = "graphlearn_courses"
	description = "Graph Learn training courses extensions"
	targetTypes = @(
		"Group"
	)
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
	)
}

New-MgSchemaExtension -BodyParameter $params
```
This example shows how to use the New-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Creating a schema extension using just a name

```powershellImport-Module Microsoft.Graph.SchemaExtensions

$params = @{
	id = "courses"
	description = "Graph Learn training courses extensions"
	targetTypes = @(
		"Group"
	)
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
	)
}

New-MgSchemaExtension -BodyParameter $params
```
This example shows how to use the New-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Creating a schema extension setting the owner

```powershellImport-Module Microsoft.Graph.SchemaExtensions

$params = @{
	id = "courses"
	description = "Graph Learn training courses extensions"
	targetTypes = @(
		"Group"
	)
	owner = "50897f70-a455-4adf-87bc-4cf17091d5ac"
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
	)
}

New-MgSchemaExtension -BodyParameter $params
```
This example shows how to use the New-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

