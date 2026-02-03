### Example 1: Get recently modified submissions

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId

```
This example will get recently modified submissions

### Example 2: Get recently modified submissions with `$select` and `$filter` options on assignmentId property

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Filter "assignmentId eq 'b20d6737-f88e-4892-8174-73aa26d18784'" -Property "LastModifiedDateTime,status" 

```
This example will get recently modified submissions with `$select` and `$filter` options on assignmentid property

### Example 3: Get recently modified submissions with `$expand` option

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -ExpandProperty "outcomes" 

```
This example will get recently modified submissions with `$expand` option

### Example 4: Get recently modified submissions with `$filter` option

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Filter "status eq 'working'" 

```
This example will get recently modified submissions with `$filter` option

### Example 5: Get recently modified submissions with `$orderby` and `$top` options

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Sort "lastModifiedDateTime" -Top 1 

```
This example will get recently modified submissions with `$orderby` and `$top` options

### Example 6: Get recently modified submissions with `$select` option

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Property "excusedDateTime" 

```
This example will get recently modified submissions with `$select` option

### Example 7: Get recently modified submissions with `$filter` option for a range on lastModifiedDateTime property

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Filter "lastModifiedDateTime gt 2024-08-25T20:45:51.3485047Z and lastModifiedDateTime lt 2024-08-28T20:45:51.3485047Z" 

```
This example will get recently modified submissions with `$filter` option for a range on lastmodifieddatetime property

