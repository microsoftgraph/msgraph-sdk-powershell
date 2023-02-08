### Example 1: Using the New-MgEducationClassAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DueDateTime = [System.DateTime]::Parse("2021-09-07T00:00:00Z")
	DisplayName = "Reading test 09.03 #4"
	Instructions = @{
		ContentType = "text"
		Content = "Read chapter 4"
	}
	Grading = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentGradeType"
		MaxPoints = 
	}
	AssignTo = @{
		"@odata.type" = "#microsoft.graph.educationAssignmentGradeType"
	}
	Status = "draft"
	AllowStudentsToAddResourcesToSubmission = $true
}
New-MgEducationClassAssignment -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
