### Example 1
``` powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationUserTaughtClass -EducationUserId $educationUserId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationUserTaughtClass -EducationUserId $educationUserId -OutFile $outFileId
```
