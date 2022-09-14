### Example 1
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationUserAssignment -EducationUserId $educationUserId -ExpandProperty "submissions" 
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationUserAssignment -EducationUserId $educationUserId
```
