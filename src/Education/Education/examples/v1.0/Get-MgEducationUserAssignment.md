### Example 1: Using the Get-MgEducationUserAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationUserAssignment -EducationUserId $educationUserId -ExpandProperty "submissions" 
```
This example shows how to use the Get-MgEducationUserAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgEducationUserAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationUserAssignment -EducationUserId $educationUserId
```
This example shows how to use the Get-MgEducationUserAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
