### Example 1: Update a feedback outcome

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	"@odata.type" = "#microsoft.graph.educationFeedbackOutcome"
	feedback = @{
		text = @{
			content = "This is feedback for the assignment as a whole."
			contentType = "text"
		}
	}
}

Update-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params

```
This example will update a feedback outcome

### Example 2: Update a points outcome

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	"@odata.type" = "#microsoft.graph.educationPointsOutcome"
	points = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentPointsGrade"
		points = 
	}
}

Update-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params

```
This example will update a points outcome

### Example 3: Update a rubric outcome

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	"@odata.type" = "#microsoft.graph.educationRubricOutcome"
	rubricQualityFeedback = @(
		@{
			qualityId = "9a145aa8-f3d9-43a1-8f77-5387ff0693f2"
			feedback = @{
				content = "This is feedback specific to the first quality of the rubric."
				contentType = "text"
			}
		}
		@{
			qualityId = "d2331fb2-2761-402e-8de6-93e0afaa076e"
			feedback = @{
				content = "This is feedback specific to the second quality of the rubric."
				contentType = "text"
			}
		}
	)
	rubricQualitySelectedLevels = @(
		@{
			qualityId = "9a145aa8-f3d9-43a1-8f77-5387ff0693f2"
			columnId = "4fb17a1d-5681-46c2-a295-4e305c3eae23"
		}
		@{
			qualityId = "d2331fb2-2761-402e-8de6-93e0afaa076e"
			columnId = "aac076bf-51ba-48c5-a2e0-ee235b0b9740"
		}
	)
}

Update-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params

```
This example will update a rubric outcome

