### Example 1: Get the assignments of the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationMeAssignment

```
This example will get the assignments of the signed-in user

### Example 2: Using `$filter` to get user assignments

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationMeAssignment -Filter "dueDateTime eq 2050-05-18T17:00:00Z" 

```
This example shows using `$filter` to get user assignments

### Example 3: Using `$orderby` to get user assignments

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationMeAssignment -Sort "status" 

```
This example shows using `$orderby` to get user assignments

