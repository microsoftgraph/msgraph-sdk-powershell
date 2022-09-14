### Example 1
``` powershell
Import-Module Microsoft.Graph.Users
$params = @{
	DisplayName = "Project expenses"
	Color = "preset9"
}
# A UPN can also be used as -UserId.
New-MgUserOutlookMasterCategory -UserId $userId -BodyParameter $params
```
