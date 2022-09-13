###Example 1
```
Import-Module Microsoft.Graph.Users
$params = @{
	Color = "preset15"
}
# A UPN can also be used as -UserId.
Update-MgUserOutlookMasterCategory -UserId $userId -OutlookCategoryId $outlookCategoryId -BodyParameter $params
```
