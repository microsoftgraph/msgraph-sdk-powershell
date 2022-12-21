### Example 1: Using the Remove-MgBetaUserOutlookTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Remove-MgBetaUserOutlookTask -UserId $userId -OutlookTaskId $outlookTaskId
```
This example shows how to use the Remove-MgBetaUserOutlookTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
