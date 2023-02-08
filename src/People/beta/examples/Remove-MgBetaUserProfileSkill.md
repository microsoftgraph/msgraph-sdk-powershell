### Example 1: Using the Remove-MgBetaUserProfileSkill Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileSkill -UserId $userId -SkillProficiencyId $skillProficiencyId
```
This example shows how to use the Remove-MgBetaUserProfileSkill Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
