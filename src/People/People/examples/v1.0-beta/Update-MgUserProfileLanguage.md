### Example 1: Using the Update-MgUserProfileLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	AllowedAudiences = "organization"
}
# A UPN can also be used as -UserId.
Update-MgUserProfileLanguage -UserId $userId -LanguageProficiencyId $languageProficiencyId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
