### Example 1: Using the Get-MgEducationClassAssignmentSubmission Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId
```
This example shows how to use the Get-MgEducationClassAssignmentSubmission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgEducationClassAssignmentSubmission Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -ExpandProperty "*" 
```
This example shows how to use the Get-MgEducationClassAssignmentSubmission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgEducationClassAssignmentSubmission Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -ExpandProperty "outcomes" 
```
This example shows how to use the Get-MgEducationClassAssignmentSubmission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgEducationClassAssignmentSubmission Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId
```
This example shows how to use the Get-MgEducationClassAssignmentSubmission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
