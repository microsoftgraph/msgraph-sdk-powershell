### Example 1: Using the Get-MgBetaUserSettingRegionalAndLanguageSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
# A UPN can also be used as -UserId.
Get-MgBetaUserSettingRegionalAndLanguageSetting -UserId $userId
```
This example shows how to use the Get-MgBetaUserSettingRegionalAndLanguageSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
