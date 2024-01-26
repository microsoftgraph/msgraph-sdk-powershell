### Example 1: Get the assignments of the signed-in user

```powershell
Import-Module Microsoft.Graph.Education

Get-MgEducationMeAssignment
```
This example shows how to use the Get-MgEducationMeAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using <code>$filter</code> to get user assignments

```powershell
Import-Module Microsoft.Graph.Education

Get-MgEducationMeAssignment -Filter "dueDateTime eq 2050-05-18T17:00:00Z"
```
This example shows how to use the Get-MgEducationMeAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using <code>$orderby</code> to get user assignments

```powershell
Import-Module Microsoft.Graph.Education

Get-MgEducationMeAssignment -Sort "createdDateTime"
```
This example shows how to use the Get-MgEducationMeAssignment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

