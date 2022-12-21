### Example 1: Using the Get-MgBetaUserOutlookTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Get-MgBetaUserOutlookTaskFolder -UserId $userId -OutlookTaskFolderId $outlookTaskFolderId
```
This example shows how to use the Get-MgBetaUserOutlookTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserOutlookTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Get-MgBetaUserOutlookTaskFolder -UserId $userId
```
This example shows how to use the Get-MgBetaUserOutlookTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
