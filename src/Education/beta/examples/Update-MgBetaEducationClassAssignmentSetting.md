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

### Example 3: Delta payload to delete, modify, and add grading categories

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
This example will delta payload to delete, modify, and add grading categories

### Example 4: Create grading schemes

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	gradingSchemes = @(
		@{
			displayName = "Pass/fail"
			grades = @(
				@{
					displayName = "Pass"
					minPercentage = 60
					defaultPercentage = 100
				}
				@{
					displayName = "Fail"
					minPercentage = 0
					defaultPercentage = 0
				}
			)
		}
		@{
			displayName = "Letters"
			grades = @(
				@{
					displayName = "A"
					minPercentage = 90
				}
				@{
					displayName = "B"
					minPercentage = 80
				}
				@{
					displayName = "C"
					minPercentage = 70
				}
				@{
					displayName = "D"
					minPercentage = 60
				}
				@{
					displayName = "F"
					minPercentage = 0
				}
			)
		}
	)
}

Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

```
This example will create grading schemes

