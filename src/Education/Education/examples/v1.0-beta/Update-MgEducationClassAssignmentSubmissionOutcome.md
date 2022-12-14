### Example 1: Using the Update-MgBetaEducationClassAssignmentSubmissionOutcome Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	"@odata.type" = "#microsoft.graph.educationFeedbackOutcome"
}
Update-MgBetaEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEducationClassAssignmentSubmissionOutcome Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaEducationClassAssignmentSubmissionOutcome Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	"@odata.type" = "#microsoft.graph.educationRubricOutcome"
	RubricQualityFeedback = @(
	)
	RubricQualitySelectedLevels = @(
	)
}
Update-MgBetaEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEducationClassAssignmentSubmissionOutcome Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Update-MgBetaEducationClassAssignmentSubmissionOutcome Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	"@odata.type" = "#microsoft.graph.educationPointsOutcome"
	Points = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentPointsGrade"
		Points = 
	}
}
Update-MgBetaEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEducationClassAssignmentSubmissionOutcome Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
