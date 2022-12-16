### Example 1: Using the Remove-MgUserOutlookTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Remove-MgUserOutlookTaskFolder -UserId $userId -OutlookTaskFolderId $outlookTaskFolderId
```
This example shows how to use the Remove-MgUserOutlookTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
