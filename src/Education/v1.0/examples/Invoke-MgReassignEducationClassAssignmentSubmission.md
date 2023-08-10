### Example 1: Request without optional Prefer header

```powershell

Import-Module Microsoft.Graph.Education

Invoke-MgReassignEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId

```
This example will request without optional prefer header

### Example 2: Request with Prefer header

```powershell

Import-Module Microsoft.Graph.Education

Invoke-MgReassignEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId

```
This example will request with prefer header

