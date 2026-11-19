### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/education/classes/37d99af7-cfc5-4e3b-8566-f7d40e4a2070/assignmentCategories/39e3d9dc-7244-42d7-8b4d-1071aae5eb41"
}

New-MgBetaEducationClassAssignmentCategoryByRef -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params

```
This example shows how to use the New-MgBetaEducationClassAssignmentCategoryByRef Cmdlet.

