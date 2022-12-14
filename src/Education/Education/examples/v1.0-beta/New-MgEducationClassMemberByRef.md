### Example 1: Using the New-MgBetaEducationClassMemberByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/education/users/13015"
}
New-MgBetaEducationClassMemberByRef -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the New-MgBetaEducationClassMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
