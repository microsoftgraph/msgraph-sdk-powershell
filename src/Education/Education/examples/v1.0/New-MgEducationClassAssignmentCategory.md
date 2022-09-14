### Example 1
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DisplayName = "Quizzes"
}
New-MgEducationClassAssignmentCategory -EducationClassId $educationClassId -BodyParameter $params
```
