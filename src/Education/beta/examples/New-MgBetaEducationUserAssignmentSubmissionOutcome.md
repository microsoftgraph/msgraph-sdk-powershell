### Example 1: Get all outcomes

```powershell
Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId
```
This example shows how to use the New-MgBetaEducationUserAssignmentSubmissionOutcome Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get outcomes filtered by outcome type

```powershell
Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmissionOutcome -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -Filter "isof('microsoft.graph.educationFeedbackResourceOutcome')"
```
This example shows how to use the New-MgBetaEducationUserAssignmentSubmissionOutcome Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

