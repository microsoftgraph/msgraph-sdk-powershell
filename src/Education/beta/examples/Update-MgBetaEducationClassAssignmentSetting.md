### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	submissionAnimationDisabled = $true
}

Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEducationClassAssignmentSetting Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	gradingCategories = @(
		@{
			displayName = "Lab"
			percentageWeight = 10
		}
		@{
			displayName = "Homework"
			percentageWeight = 80
		}
		@{
			displayName = "Test"
			percentageWeight = 10
		}
	)
}

Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEducationClassAssignmentSetting Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	"gradingCategories@delta" = @(
		@{
			id = "fb859cd3-943b-4cd6-9bbe-fe1c39eace0e"
			displayName = "Lab Test"
		}
		@{
			"@odata.context" = "https://graph.microsoft.com/beta/$metadata#gradingCategories/$deletedEntity"
			id = "e2a86277-24f9-4f29-8196-8c83fc69d00d"
			reason = "deleted"
		}
		@{
			displayName = "Lab Practice"
			percentageWeight = 
		}
		@{
			displayName = "Lab Theory"
			percentageWeight = 
		}
	)
}

Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEducationClassAssignmentSetting Cmdlet.

