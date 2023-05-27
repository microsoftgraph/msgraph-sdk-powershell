### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	"@odata.type" = "#microsoft.graph.educationFeedbackResourceOutcome"
	feedbackResource = @{
		"@odata.type" = "#microsoft.graph.educationWordResource"
		displayName = "Document1.docx"
	}
}

New-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```
This example shows how to use the New-MgEducationUserAssignmentSubmissionOutcome Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

