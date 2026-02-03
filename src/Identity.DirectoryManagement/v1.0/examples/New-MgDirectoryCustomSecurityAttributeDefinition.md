### Example 1: Add a custom security attribute

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

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

New-MgDirectoryCustomSecurityAttributeDefinition -BodyParameter $params

```
This example will add a custom security attribute

### Example 2: Add a custom security attribute that supports multiple predefined values

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

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

New-MgDirectoryCustomSecurityAttributeDefinition -BodyParameter $params

```
This example will add a custom security attribute that supports multiple predefined values

### Example 3: Add a custom security attribute with a list of predefined values

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

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

New-MgDirectoryCustomSecurityAttributeDefinition -BodyParameter $params

```
This example will add a custom security attribute with a list of predefined values

