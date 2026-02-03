### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users

$params = @{
	isEnabled = "false"
}

Update-MgBetaUserSettingItemInsight -UserId $userId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserSettingItemInsight Cmdlet.

