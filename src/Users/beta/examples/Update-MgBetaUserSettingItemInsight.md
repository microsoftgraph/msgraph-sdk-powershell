### Example 1: Using the Update-MgBetaUserSettingItemInsight Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	IsEnabled = "false"
}
Update-MgBetaUserSettingItemInsight -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserSettingItemInsight Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
