### Example 1: Using the Remove-MgUserProfileLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileLanguage -UserId $userId -LanguageProficiencyId $languageProficiencyId
```
This example shows how to use the Remove-MgUserProfileLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
