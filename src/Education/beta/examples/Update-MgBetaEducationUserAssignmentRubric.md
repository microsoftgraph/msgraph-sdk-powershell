### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/me/rubrics/ceb3863e-6912-4ea9-ac41-3c2bb7b6672d"
}

Set-MgBetaEducationClassAssignmentRubricByRef -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaEducationUserAssignmentRubric Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

