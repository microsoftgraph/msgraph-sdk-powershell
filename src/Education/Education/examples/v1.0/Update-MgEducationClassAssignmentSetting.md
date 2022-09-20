### Example 1: Using the Update-MgEducationClassAssignmentSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	SubmissionAnimationDisabled = $true
}
Update-MgEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Update-MgEducationClassAssignmentSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
