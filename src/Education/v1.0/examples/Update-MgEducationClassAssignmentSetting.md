### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

$params = @{
	submissionAnimationDisabled = $true
}

Update-MgEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Update-MgEducationClassAssignmentSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

