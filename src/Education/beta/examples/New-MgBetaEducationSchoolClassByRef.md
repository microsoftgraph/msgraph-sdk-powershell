### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/education/classes/11006"
}

New-MgBetaEducationSchoolClassByRef -EducationSchoolId $educationSchoolId -BodyParameter $params

```
This example shows how to use the New-MgBetaEducationSchoolClassByRef Cmdlet.

