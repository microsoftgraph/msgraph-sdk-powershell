### Example 1
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DisplayName = "Reading and review test 09.03 #5"
	Instructions = @{
		ContentType = "text"
		Content = "Read chapter 5 and write your review"
	}
	DueDateTime = [System.DateTime]::Parse("2021-09-10T00:00:00Z")
	AddedStudentAction = "none"
}
Update-MgEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
