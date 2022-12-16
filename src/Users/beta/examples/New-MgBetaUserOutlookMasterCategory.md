### Example 1: Using the New-MgUserOutlookMasterCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	DisplayName = "Project expenses"
	Color = "preset9"
}
# A UPN can also be used as -UserId.
New-MgUserOutlookMasterCategory -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserOutlookMasterCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
