### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	allowedAudiences = "organization"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserProfileLanguage -UserId $userId -LanguageProficiencyId $languageProficiencyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileLanguage Cmdlet.

