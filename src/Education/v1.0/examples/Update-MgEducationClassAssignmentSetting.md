### Example 1: Update submissionAnimationDisabled

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	submissionAnimationDisabled = $true
}

Update-MgEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

```
This example will update submissionanimationdisabled

### Example 2: Create grading categories

```powershell

Import-Module Microsoft.Graph.Education

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

Update-MgEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

```
This example will create grading categories

### Example 3: Delta payload to delete, modify and add grading categories.

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	"gradingCategories@delta" = @(
		@{
			id = "03bd9196-ce2e-41bd-902f-df9ae02de4db"
			displayName = "Lab Updated"
		}
		@{
			"@odata.context" = "https://graph.microsoft.com/beta/$metadata#gradingCategories/$deletedEntity"
			id = "109e5d73-3ef7-42a5-88d8-7e30cdb85f06"
			reason = "deleted"
		}
		@{
			displayName = "New Homework"
			percentageWeight = 
		}
	)
}

Update-MgEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

```
This example will delta payload to delete, modify and add grading categories.

