### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	addedStudentAction = "assignIfOpen"
	addToCalendarAction = "studentsAndTeamOwners"
	notificationChannelUrl = "https://graph.microsoft.com/beta/teams('id')/channels('id')"
}

Update-MgBetaEducationClassAssignmentDefault -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEducationClassAssignmentDefault Cmdlet.

