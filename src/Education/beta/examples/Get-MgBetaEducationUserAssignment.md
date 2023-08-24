### Example 1: Get assignments of a user

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationUserAssignment -EducationUserId $educationUserId

```
This example will get assignments of a user

### Example 2: Get user assignments with expand submissions

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationUserAssignment -EducationUserId $educationUserId -ExpandProperty "submissions" 

```
This example will get user assignments with expand submissions

