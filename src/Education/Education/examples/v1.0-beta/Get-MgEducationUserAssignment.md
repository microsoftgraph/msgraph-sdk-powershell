### Example 1: Using the Get-MgBetaEducationUserAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
Get-MgBetaEducationUserAssignment -EducationUserId $educationUserId -ExpandProperty "submissions" 
```
This example shows how to use the Get-MgBetaEducationUserAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaEducationUserAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Education
Get-MgBetaEducationUserAssignment -EducationUserId $educationUserId
```
This example shows how to use the Get-MgBetaEducationUserAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
