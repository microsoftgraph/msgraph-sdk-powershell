### Example 1: Using the Set-MgEducationClassAssignmentUpResourceFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
}
Set-MgEducationClassAssignmentUpResourceFolder -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -BodyParameter $params
```
This example shows how to use the Set-MgEducationClassAssignmentUpResourceFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
