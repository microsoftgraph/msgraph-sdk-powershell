### Example 1: Using the New-MgBetaEducationSchoolClassByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/education/classes/11006"
}
New-MgBetaEducationSchoolClassByRef -EducationSchoolId $educationSchoolId -BodyParameter $params
```
This example shows how to use the New-MgBetaEducationSchoolClassByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
