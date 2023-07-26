### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId
```
This example shows how to use the Get-MgBetaEducationClassAssignmentSubmission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -ExpandProperty "*"
```
This example shows how to use the Get-MgBetaEducationClassAssignmentSubmission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

