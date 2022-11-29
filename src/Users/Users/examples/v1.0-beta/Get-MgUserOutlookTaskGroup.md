### Example 1: Using the Get-MgUserOutlookTaskGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserOutlookTaskGroup -UserId $userId -OutlookTaskGroupId $outlookTaskGroupId
```
This example shows how to use the Get-MgUserOutlookTaskGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserOutlookTaskGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserOutlookTaskGroup -UserId $userId
```
This example shows how to use the Get-MgUserOutlookTaskGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
