### Example 1: Update submissionAnimationDisabled

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	submissionAnimationDisabled = $true
}

Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

```
This example will update submissionanimationdisabled

### Example 2: Create grading categories

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
This example will create grading categories

