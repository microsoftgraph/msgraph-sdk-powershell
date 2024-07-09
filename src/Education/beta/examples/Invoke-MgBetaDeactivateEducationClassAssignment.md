### Example 1: Mark an assignment inactive without the optional Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Education

Invoke-MgBetaDeactivateEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId

```
This example will mark an assignment inactive without the optional prefer header

### Example 2: Mark an assignment inactive with the optional Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Education

Invoke-MgBetaDeactivateEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId

```
This example will mark an assignment inactive with the optional prefer header

