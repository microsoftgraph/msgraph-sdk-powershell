### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	displayName = "Quizzes"
}

New-MgEducationClassAssignmentCategory -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the New-MgEducationClassAssignmentCategory Cmdlet.

