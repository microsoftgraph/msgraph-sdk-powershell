### Example 1
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignment -EducationClassId $educationClassId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignment -EducationClassId $educationClassId -ExpandProperty "resources" 
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId
```
