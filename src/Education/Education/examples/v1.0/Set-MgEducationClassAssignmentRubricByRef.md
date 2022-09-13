###Example 1
```
Import-Module Microsoft.Graph.Education
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/education/me/rubrics/ceb3863e-6912-4ea9-ac41-3c2bb7b6672d"
}
Set-MgEducationClassAssignmentRubricByRef -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
