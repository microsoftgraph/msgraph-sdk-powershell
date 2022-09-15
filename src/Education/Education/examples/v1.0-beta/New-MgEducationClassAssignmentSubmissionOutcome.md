### Example 1: Using the New-MgEducationClassAssignmentSubmissionOutcome Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.type" = "#microsoft.graph.educationFeedbackResourceOutcome"
	FeedbackResource = @{
		"@odata.type" = "#microsoft.graph.educationWordResource"
		DisplayName = "Document1.docx"
	}
}
New-MgEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentSubmissionOutcome Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
