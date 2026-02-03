### Example 1: Get assignments

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassAssignment -EducationClassId $educationClassId

```
This example will get assignments

### Example 2: Get assignments using $expand options

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationClassAssignment -EducationClassId $educationClassId -ExpandProperty "resources" 

```
This example will get assignments using $expand options

