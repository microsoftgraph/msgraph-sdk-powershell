### Example 1: Using the New-MgEducationClassAssignmentCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DisplayName = "Quizzes"
}
New-MgEducationClassAssignmentCategory -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassAssignmentCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
