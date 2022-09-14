### Example 1
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	SubmissionAnimationDisabled = $true
}
Update-MgEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params
```
