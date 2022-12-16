### Example 1: Using the Update-MgUserSettingItemInsight Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	IsEnabled = "false"
}
Update-MgUserSettingItemInsight -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgUserSettingItemInsight Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
