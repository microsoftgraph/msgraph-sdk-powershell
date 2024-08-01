### Example 1: Request with optional Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Education

Invoke-MgBetaExcuseEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId

```
This example will request with optional prefer header

### Example 2: Request without the Prefer request header

```powershell

Import-Module Microsoft.Graph.Beta.Education

Invoke-MgBetaExcuseEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId

```
This example will request without the prefer request header

