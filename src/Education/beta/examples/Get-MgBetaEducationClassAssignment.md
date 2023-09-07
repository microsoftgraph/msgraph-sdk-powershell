### Example 1: Get education assignment

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId

```
This example will get education assignment

### Example 2: Get assignment in inactive state with optional Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId

```
This example will get assignment in inactive state with optional prefer header

