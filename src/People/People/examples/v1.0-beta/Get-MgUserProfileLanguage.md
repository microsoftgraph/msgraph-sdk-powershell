### Example 1: Using the Get-MgBetaUserProfileLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileLanguage -UserId $userId -LanguageProficiencyId $languageProficiencyId
```
This example shows how to use the Get-MgBetaUserProfileLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileLanguage -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
