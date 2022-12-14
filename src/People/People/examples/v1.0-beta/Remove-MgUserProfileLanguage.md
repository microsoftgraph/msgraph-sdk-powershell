### Example 1: Using the Remove-MgBetaUserProfileLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileLanguage -UserId $userId -LanguageProficiencyId $languageProficiencyId
```
This example shows how to use the Remove-MgBetaUserProfileLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
