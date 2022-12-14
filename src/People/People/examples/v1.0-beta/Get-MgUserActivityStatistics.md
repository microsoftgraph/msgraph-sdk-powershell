### Example 1: Using the Get-MgBetaUserActivityStatistics Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserActivityStatistics -UserId $userId
```
This example shows how to use the Get-MgBetaUserActivityStatistics Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
