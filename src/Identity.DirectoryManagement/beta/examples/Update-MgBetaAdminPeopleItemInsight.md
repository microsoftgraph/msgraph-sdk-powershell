### Example 1: Update settings for item insights

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	disabledForGroup = "edbfe4fb-ec70-4300-928f-dbb2ae86c981"
}

Update-MgBetaAdminPeopleItemInsight -BodyParameter $params

```
This example will update settings for item insights

