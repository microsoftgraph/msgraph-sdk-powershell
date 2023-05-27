### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

$params = @{
	submissionAnimationDisabled = $true
}

Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaEducationClassAssignmentSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

