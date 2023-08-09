### Example 1: Get submissions

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId

```
This example will get submissions

### Example 2: Get submissions with $expand options

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -ExpandProperty "outcomes" 

```
This example will get submissions with $expand options

