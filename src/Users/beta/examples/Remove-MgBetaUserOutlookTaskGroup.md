### Example 1: Using the Remove-MgBetaUserOutlookTaskGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Remove-MgBetaUserOutlookTaskGroup -UserId $userId -OutlookTaskGroupId $outlookTaskGroupId
```
This example shows how to use the Remove-MgBetaUserOutlookTaskGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
