### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	displayName = "Test updated"
}

Update-MgEducationClassAssignmentSettingGradingCategory -EducationClassId $educationClassId -EducationGradingCategoryId $educationGradingCategoryId -BodyParameter $params

```
This example shows how to use the Update-MgEducationClassAssignmentSettingGradingCategory Cmdlet.

