###Example 1
```
Import-Module Microsoft.Graph.Users
# A UPN can also be used as -UserId.
Remove-MgUserOutlookMasterCategory -UserId $userId -OutlookCategoryId $outlookCategoryId
```
