### Example 1: Get submissions

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId

```
This example will get submissions

### Example 2: Get submissions with $expand options

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -ExpandProperty "outcomes" 

```
This example will get submissions with $expand options

### Example 3: Get submissions - Request with optional Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId

```
This example will get submissions - request with optional prefer header

### Example 2: Using `$filter` to get submissions

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -Filter "id eq 'ff2c7fe6-91cd-57a4-aa62-5b9c6b73222a'" 

```
This example shows using `$filter` to get submissions

