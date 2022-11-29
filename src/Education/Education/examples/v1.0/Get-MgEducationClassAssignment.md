### Example 1: Using the Get-MgEducationClassAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignment -EducationClassId $educationClassId
```
This example shows how to use the Get-MgEducationClassAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgEducationClassAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignment -EducationClassId $educationClassId -ExpandProperty "resources" 
```
This example shows how to use the Get-MgEducationClassAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgEducationClassAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId
```
This example shows how to use the Get-MgEducationClassAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
