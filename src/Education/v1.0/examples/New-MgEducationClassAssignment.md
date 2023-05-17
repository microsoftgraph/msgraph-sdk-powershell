### Example 1: Get assignments

```powershellImport-Module Microsoft.Graph.Education

Get-MgEducationClassAssignment -EducationClassId $educationClassId
```
This example shows how to use the New-MgEducationClassAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get assignments using $expand options

```powershellImport-Module Microsoft.Graph.Education

Get-MgEducationClassAssignment -EducationClassId $educationClassId -ExpandProperty "resources"
```
This example shows how to use the New-MgEducationClassAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

