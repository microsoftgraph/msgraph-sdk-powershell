### Example 1: Using the Update-MgUserSettingContactMergeSuggestion Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	IsEnabled = $false
}
# A UPN can also be used as -UserId.
Update-MgUserSettingContactMergeSuggestion -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgUserSettingContactMergeSuggestion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
