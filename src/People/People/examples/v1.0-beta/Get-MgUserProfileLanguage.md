### Example 1: Using the Get-MgUserProfileLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileLanguage -UserId $userId -LanguageProficiencyId $languageProficiencyId
```
This example shows how to use the Get-MgUserProfileLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileLanguage -UserId $userId
```
This example shows how to use the Get-MgUserProfileLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
