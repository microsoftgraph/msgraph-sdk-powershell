### Example 1: Using the Get-MgBetaUserOutlookTaskFolderTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Get-MgBetaUserOutlookTaskFolderTask -UserId $userId -OutlookTaskFolderId $outlookTaskFolderId
```
This example shows how to use the Get-MgBetaUserOutlookTaskFolderTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
