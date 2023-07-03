### Example 1: Using the Get-MgBetaUserProfileSkill Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileSkill -UserId $userId -SkillProficiencyId $skillProficiencyId
```
This example shows how to use the Get-MgBetaUserProfileSkill Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileSkill Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileSkill -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileSkill Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
