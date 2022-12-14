### Example 1: Using the Update-MgBetaUserOutlookMasterCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	Color = "preset15"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserOutlookMasterCategory -UserId $userId -OutlookCategoryId $outlookCategoryId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserOutlookMasterCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
