### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Education

Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -ExpandProperty "*"
```
This example shows how to use the Get-MgEducationClassAssignmentSubmission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

