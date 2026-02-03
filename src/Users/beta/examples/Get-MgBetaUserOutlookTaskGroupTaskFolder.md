### Example 1: Using the Get-MgBetaUserOutlookTaskGroupTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Get-MgBetaUserOutlookTaskGroupTaskFolder -UserId $userId -OutlookTaskGroupId $outlookTaskGroupId
```
This example shows how to use the Get-MgBetaUserOutlookTaskGroupTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
