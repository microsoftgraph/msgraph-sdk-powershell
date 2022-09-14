### Example 1
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	AddedStudentAction = "assignIfOpen"
	NotificationChannelUrl = "https://graph.microsoft.com/beta/teams('acdefc6b-2dc6-4e71-b1e9-6d9810ab1793')/channels('3da03fc4-8eac-4459-84fb-1422dc01f65e')"
}
Update-MgEducationClassAssignmentDefault -EducationClassId $educationClassId -BodyParameter $params
```
