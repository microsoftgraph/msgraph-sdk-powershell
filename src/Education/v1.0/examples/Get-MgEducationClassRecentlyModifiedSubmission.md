### Example 1: Get recently modified submissions

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId

```
This example will get recently modified submissions

### Example 2: Get recently modified submissions with `$select` and `$filter` options on assignmentId property

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Filter "assignmentId eq 'b20d6737-f88e-4892-8174-73aa26d18784'" -Property "LastModifiedDateTime,status" 

```
This example will get recently modified submissions with `$select` and `$filter` options on assignmentid property

### Example 3: Get recently modified submissions with `$expand` option

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -ExpandProperty "outcomes" 

```
This example will get recently modified submissions with `$expand` option

### Example 4: Get recently modified submissions with `$filter` option

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Filter "lastModifiedDateTime gt 2025-04-10T19:02:00.8753517Z" 

```
This example will get recently modified submissions with `$filter` option

### Example 5: Get recently modified submissions with `$orderby` and `$top` options

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Sort "lastModifiedDateTime" -Top 1 

```
This example will get recently modified submissions with `$orderby` and `$top` options

### Example 6: Get recently modified submissions with `$select` option

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Property "excusedDateTime" 

```
This example will get recently modified submissions with `$select` option

### Example 7: Get recently modified submissions with `$filter` option for a range on lastModifiedDateTime property

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Filter "lastModifiedDateTime gt 2025-04-10T19:02:00.8753517Z and lastModifiedDateTime lt 2025-04-14T23:02:00.8753517Z" 

```
This example will get recently modified submissions with `$filter` option for a range on lastmodifieddatetime property

### Example 8: Get recently modified submissions with `$filter` option for lastModifiedDateTime property using less than(lt) operator

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassRecentlyModifiedSubmission -EducationClassId $educationClassId -Filter "lastModifiedDateTime lt 2025-04-29T15:48:31.3785886Z" 

```
This example will get recently modified submissions with `$filter` option for lastmodifieddatetime property using less than(lt) operator

