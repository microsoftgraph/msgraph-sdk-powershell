### Example 1: Get all resources

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId

```
This example will get all resources

### Example 2: Using `$filter` to get resources

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -Filter " id eq 'c4682401-6866-4962-94d9-7499782a13e9'" 

```
This example shows using `$filter` to get resources

### Example 3: Using `$orderby` to get resources

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignmentSubmissionResource -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId -Sort "resource/createdDateTime" 

```
This example shows using `$orderby` to get resources

