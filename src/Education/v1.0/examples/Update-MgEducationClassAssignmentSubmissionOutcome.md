### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	"@odata.type" = "#microsoft.graph.educationFeedbackOutcome"
}

Update-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params
```
This example shows how to use the Update-MgEducationClassAssignmentSubmissionOutcome Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	"@odata.type" = "#microsoft.graph.educationRubricOutcome"
	rubricQualityFeedback = @(
	)
	rubricQualitySelectedLevels = @(
	)
}

Update-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -EducationOutcomeId $educationOutcomeId -BodyParameter $params
```
This example shows how to use the Update-MgEducationClassAssignmentSubmissionOutcome Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

