### Example 1: Using the Set-MgBetaEducationClassAssignmentRubricByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/me/rubrics/{id}"
}
Set-MgBetaEducationClassAssignmentRubricByRef -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the Set-MgBetaEducationClassAssignmentRubricByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
