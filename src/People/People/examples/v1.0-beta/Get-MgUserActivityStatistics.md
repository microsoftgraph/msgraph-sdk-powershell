### Example 1: Using the Get-MgUserActivityStatistics Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserActivityStatistics -UserId $userId
```
This example shows how to use the Get-MgUserActivityStatistics Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
