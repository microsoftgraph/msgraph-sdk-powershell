### Example 1: Using the New-MgUserProfileLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	DisplayName = "Norwegian Bokmål"
	Tag = "nb-NO"
	Spoken = "nativeOrBilingual"
	Written = "nativeOrBilingual"
	Reading = "nativeOrBilingual"
}
# A UPN can also be used as -UserId.
New-MgUserProfileLanguage -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
