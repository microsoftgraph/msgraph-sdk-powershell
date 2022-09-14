### Example 1: Using the Get-MgUserOutlookMasterCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserOutlookMasterCategory -UserId $userId
```
This example shows how to use the Get-MgUserOutlookMasterCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserOutlookMasterCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Get-MgUserOutlookMasterCategory -UserId $userId -OutlookCategoryId $outlookCategoryId
```
This example shows how to use the Get-MgUserOutlookMasterCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
