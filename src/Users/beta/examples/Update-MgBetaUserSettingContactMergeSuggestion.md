### Example 1: Using the Update-MgBetaUserSettingContactMergeSuggestion Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	IsEnabled = $false
}
# A UPN can also be used as -UserId.
Update-MgBetaUserSettingContactMergeSuggestion -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserSettingContactMergeSuggestion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
