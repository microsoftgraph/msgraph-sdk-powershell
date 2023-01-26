### Example 1: Using the Update-MgBetaUserProfileLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	AllowedAudiences = "organization"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfileLanguage -UserId $userId -LanguageProficiencyId $languageProficiencyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
