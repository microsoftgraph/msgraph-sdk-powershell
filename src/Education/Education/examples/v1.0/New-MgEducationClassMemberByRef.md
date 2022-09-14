### Example 1: Using the New-MgEducationClassMemberByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/users/13015"
}
New-MgEducationClassMemberByRef -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the New-MgEducationClassMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
