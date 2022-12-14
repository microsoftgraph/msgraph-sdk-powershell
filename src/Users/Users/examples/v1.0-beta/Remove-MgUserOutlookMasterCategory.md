### Example 1: Using the Remove-MgBetaUserOutlookMasterCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Remove-MgBetaUserOutlookMasterCategory -UserId $userId -OutlookCategoryId $outlookCategoryId
```
This example shows how to use the Remove-MgBetaUserOutlookMasterCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
