### Example 1: Using the Update-MgUserSettingRegionalAndLanguageSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	AuthoringLanguages = @(
		@{
			Locale = "en-US"
		}
		@{
			Locale = "es-MX"
		}
	)
	DefaultRegionalFormat = @{
		Locale = "en-US"
	}
}
# A UPN can also be used as -UserId.
Update-MgUserSettingRegionalAndLanguageSetting -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgUserSettingRegionalAndLanguageSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
