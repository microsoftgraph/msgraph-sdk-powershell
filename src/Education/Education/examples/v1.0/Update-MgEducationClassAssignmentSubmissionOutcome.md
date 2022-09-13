###Example 1
```
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.type" = "#microsoft.graph.educationFeedbackOutcome"
}
Update-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.type" = "#microsoft.graph.educationRubricOutcome"
	RubricQualityFeedback = @(
	)
	RubricQualitySelectedLevels = @(
	)
}
Update-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params
```
###Example 3
```
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.type" = "#microsoft.graph.educationPointsOutcome"
	Points = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentPointsGrade"
		Points = 
	}
}
Update-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params
```
