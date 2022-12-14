### Example 1: Using the Complete-MgBetaUserOutlookTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Complete-MgBetaUserOutlookTask -UserId $userId -OutlookTaskId $outlookTaskId
```
This example shows how to use the Complete-MgBetaUserOutlookTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
