### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/users/13015"
}

New-MgBetaEducationClassMemberByRef -EducationClassId $educationClassId -BodyParameter $params
```
This example shows how to use the New-MgBetaEducationClassMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

