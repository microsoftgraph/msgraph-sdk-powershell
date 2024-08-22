### Example 1: Get assignments

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignment -EducationClassId $educationClassId

```
This example will get assignments

### Example 2: Get assignments using $expand options

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignment -EducationClassId $educationClassId -ExpandProperty "resources" 

```
This example will get assignments using $expand options

### Example 3: Using `$filter` to get assignments

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignment -EducationClassId $educationClassId -Filter "status eq 'assigned'" 

```
This example shows using `$filter` to get assignments

### Example 4: Using `$orderby` to get assignments

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignment -EducationClassId $educationClassId -Ordeby " id" 

```
This example shows using `$orderby` to get assignments

### Example 5: Use `$expand` to get the gradingScheme for an assignment

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationClassAssignment -EducationClassId $educationClassId -ExpandProperty "gradingScheme" 

```
This example will use `$expand` to get the gradingscheme for an assignment

