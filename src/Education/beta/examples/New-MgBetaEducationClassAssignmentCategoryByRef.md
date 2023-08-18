### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Education

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/classes/acdefc6b-2dc6-4e71-b1e9-6d9810ab1793/assignmentCategories/ec98f158-341d-4fea-9f8c-14a250d489ac"
}

New-MgBetaEducationClassAssignmentCategoryByRef -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgBetaEducationClassAssignmentCategoryByRef Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

