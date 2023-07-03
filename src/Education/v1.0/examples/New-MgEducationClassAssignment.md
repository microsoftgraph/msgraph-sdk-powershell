### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	dueDateTime = [System.DateTime]::Parse("2022-09-16T00:00:00Z")
	displayName = "Reading test 09.14"
	instructions = @{
		contentType = "text"
		content = "Read chapter 4"
	}
	grading = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentPointsGradeType"
		maxPoints = 
	}
	assignTo = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentClassRecipient"
	}
	status = "draft"
	allowStudentsToAddResourcesToSubmission = $true
}

New-MgEducationClassAssignment -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

