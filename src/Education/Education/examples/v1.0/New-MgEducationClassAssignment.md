### Example 1
``` powershell
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
