### Example 1
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -ExpandProperty "*" 
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -ExpandProperty "outcomes" 
```
### Example 4
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId
```
