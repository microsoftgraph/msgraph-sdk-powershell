### Example 1: Using the Remove-MgBetaUserOutlookTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Remove-MgBetaUserOutlookTaskFolder -UserId $userId -OutlookTaskFolderId $outlookTaskFolderId
```
This example shows how to use the Remove-MgBetaUserOutlookTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
