### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Education

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/classes/11006"
}

New-MgEducationSchoolClassByRef -EducationSchoolId $educationSchoolId -BodyParameter $params

```
This example shows how to use the New-MgEducationSchoolClassByRef Cmdlet.

