###Example 1
```
Import-Module Microsoft.Graph.Education
Get-MgEducationUserAssignment -EducationUserId $educationUserId -ExpandProperty "submissions" 
```
###Example 2
```
Import-Module Microsoft.Graph.Education
Get-MgEducationUserAssignment -EducationUserId $educationUserId
```
