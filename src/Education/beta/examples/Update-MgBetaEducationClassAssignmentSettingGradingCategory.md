### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	displayName = "Quiz-1"
}

Update-MgBetaEducationClassAssignmentSettingGradingCategory -EducationClassId $educationClassId -EducationGradingCategoryId $educationGradingCategoryId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEducationClassAssignmentSettingGradingCategory Cmdlet.

