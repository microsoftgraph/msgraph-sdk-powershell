### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users

$params = @{
	isEnabled = "false"
}

Update-MgUserSettingItemInsight -UserId $userId -BodyParameter $params

```
This example shows how to use the Update-MgUserSettingItemInsight Cmdlet.

