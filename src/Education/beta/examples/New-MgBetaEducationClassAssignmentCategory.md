### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	displayName = "Quizzes"
}

New-MgBetaEducationClassAssignmentCategory -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the New-MgBetaEducationClassAssignmentCategory Cmdlet.

