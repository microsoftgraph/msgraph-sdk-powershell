### Example 1
``` powershell
Import-Module Microsoft.Graph.Education
$params = @{
	DisplayName = "Example Credit Rubric after display name patch"
}
Update-MgEducationMeRubric -EducationRubricId $educationRubricId -BodyParameter $params
```
