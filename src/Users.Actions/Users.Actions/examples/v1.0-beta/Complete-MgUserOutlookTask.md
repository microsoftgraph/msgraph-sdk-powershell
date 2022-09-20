### Example 1: Using the Complete-MgUserOutlookTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Complete-MgUserOutlookTask -UserId $userId -OutlookTaskId $outlookTaskId
```
This example shows how to use the Complete-MgUserOutlookTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
