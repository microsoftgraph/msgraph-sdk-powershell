### Example 1: Using the New-MgBetaUserOutlookMasterCategory Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	DisplayName = "Project expenses"
	Color = "preset9"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOutlookMasterCategory -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOutlookMasterCategory Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
