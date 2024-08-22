### Example 1: Get Resources

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId

```
This example will get resources

### Example 2: Using `$filter` to get resources

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -Filter "id eq 'bc98d7cd-7cf3-449c-b1b9-3a9683024d4e'" 

```
This example shows using `$filter` to get resources

### Example 3: Using `$orderby` to get resources

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -Sort "resource/createdDateTime" 

```
This example shows using `$orderby` to get resources

