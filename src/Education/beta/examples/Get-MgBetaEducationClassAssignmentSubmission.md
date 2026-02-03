### Example 1: Request without optional Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId

```
This example will request without optional prefer header

### Example 2: Request with optional Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId

```
This example will request with optional prefer header

### Example 3: Get submission with $expand options

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -ExpandProperty "*" 

```
This example will get submission with $expand options

