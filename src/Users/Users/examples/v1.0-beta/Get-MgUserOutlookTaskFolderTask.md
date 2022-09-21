### Example 1: Using the Get-MgUserOutlookTaskFolderTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserOutlookTaskFolderTask -UserId $userId -OutlookTaskFolderId $outlookTaskFolderId
```
This example shows how to use the Get-MgUserOutlookTaskFolderTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
