###Example 1
```
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignment -EducationClassId $educationClassId
```
###Example 2
```
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignment -EducationClassId $educationClassId -ExpandProperty "resources" 
```
###Example 3
```
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId
```
