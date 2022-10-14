### Example 1: Using the Remove-MgUserOutlookMasterCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Remove-MgUserOutlookMasterCategory -UserId $userId -OutlookCategoryId $outlookCategoryId
```
This example shows how to use the Remove-MgUserOutlookMasterCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
