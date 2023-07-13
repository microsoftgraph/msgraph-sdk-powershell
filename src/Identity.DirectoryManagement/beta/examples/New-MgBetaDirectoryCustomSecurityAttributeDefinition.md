### Example 1: Add a custom security attribute

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	attributeSet = "Engineering"
	description = "Target completion date"
	isCollection = $false
	isSearchable = $true
	name = "ProjectDate"
	status = "Available"
	type = "String"
	usePreDefinedValuesOnly = $false
}

New-MgBetaDirectoryCustomSecurityAttributeDefinition -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Add a custom security attribute that supports multiple predefined values

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	attributeSet = "Engineering"
	description = "Active projects for user"
	isCollection = $true
	isSearchable = $true
	name = "Project"
	status = "Available"
	type = "String"
	usePreDefinedValuesOnly = $true
}

New-MgBetaDirectoryCustomSecurityAttributeDefinition -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Add a custom security attribute with a list of predefined values

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	attributeSet = "Engineering"
	description = "Active projects for user"
	isCollection = $true
	isSearchable = $true
	name = "Project"
	status = "Available"
	type = "String"
	usePreDefinedValuesOnly = $true
	allowedValues = @(
		@{
			id = "Alpine"
			isActive = $true
		}
		@{
			id = "Baker"
			isActive = $true
		}
		@{
			id = "Cascade"
			isActive = $true
		}
	)
}

New-MgBetaDirectoryCustomSecurityAttributeDefinition -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

