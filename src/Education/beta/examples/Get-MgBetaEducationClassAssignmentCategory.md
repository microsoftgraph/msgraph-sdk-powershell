### Example 1: Get assignment categories

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentCategory -EducationClassId $educationClassId

```
This example will get assignment categories

### Example 2: Using `$filter` to get assignment categories

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentCategory -EducationClassId $educationClassId -Filter "id eq 'd4cb4f68-9136-48d3-9054-c1208ea274f0'" 

```
This example shows using `$filter` to get assignment categories

### Example 3: Using `$orderby` to get assignment categories

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentCategory -EducationClassId $educationClassId -Sort "displayName" 

```
This example shows using `$orderby` to get assignment categories

