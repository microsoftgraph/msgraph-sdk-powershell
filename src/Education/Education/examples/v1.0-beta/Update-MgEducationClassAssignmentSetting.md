### Example 1: Using the Update-MgBetaEducationClassAssignmentSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	SubmissionAnimationDisabled = $true
}
Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEducationClassAssignmentSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
