###Example 1
```
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId
```
###Example 2
```
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -ExpandProperty "*" 
```
###Example 3
```
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -ExpandProperty "outcomes" 
```
###Example 4
```
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId
```
