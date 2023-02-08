### Example 1: Using the New-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	AttributeSet = "Engineering"
	Description = "Active projects for user"
	IsCollection = $true
	IsSearchable = $true
	Name = "Project"
	Status = "Available"
	Type = "String"
	UsePreDefinedValuesOnly = $true
	AllowedValues = @(
		@{
			Id = "Alpine"
			IsActive = $true
		}
		@{
			Id = "Baker"
			IsActive = $true
		}
		@{
			Id = "Cascade"
			IsActive = $true
		}
	)
}
New-MgBetaDirectoryCustomSecurityAttributeDefinition -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	AttributeSet = "Engineering"
	Description = "Target completion date"
	IsCollection = $false
	IsSearchable = $true
	Name = "ProjectDate"
	Status = "Available"
	Type = "String"
	UsePreDefinedValuesOnly = $false
}
New-MgBetaDirectoryCustomSecurityAttributeDefinition -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	AttributeSet = "Engineering"
	Description = "Active projects for user"
	IsCollection = $true
	IsSearchable = $true
	Name = "Project"
	Status = "Available"
	Type = "String"
	UsePreDefinedValuesOnly = $true
}
New-MgBetaDirectoryCustomSecurityAttributeDefinition -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryCustomSecurityAttributeDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
