### Example 1: Using the Update-MgBetaEducationClassAssignmentDefault Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	AddedStudentAction = "assignIfOpen"
	AddToCalendarAction = "studentsAndTeamOwners"
	NotificationChannelUrl = "https://graph.microsoft.com/beta/teams('id')/channels('id')"
}
Update-MgBetaEducationClassAssignmentDefault -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEducationClassAssignmentDefault Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
