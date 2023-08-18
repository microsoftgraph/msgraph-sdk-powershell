### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/education/users/14011"
}

New-MgBetaEducationClassTeacherByRef -EducationClassId $educationClassId -BodyParameter $params

```
This example shows how to use the New-MgBetaEducationClassTeacherByRef Cmdlet.

