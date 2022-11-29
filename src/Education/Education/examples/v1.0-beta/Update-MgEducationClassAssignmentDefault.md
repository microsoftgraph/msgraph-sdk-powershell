### Example 1: Using the Update-MgEducationClassAssignmentDefault Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	AddedStudentAction = "assignIfOpen"
	AddToCalendarAction = "studentsAndTeamOwners"
	NotificationChannelUrl = "https://graph.microsoft.com/beta/teams('id')/channels('id')"
}
Update-MgEducationClassAssignmentDefault -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Update-MgEducationClassAssignmentDefault Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
