### Example 1: Using the Remove-MgUserProfileSkill Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileSkill -UserId $userId -SkillProficiencyId $skillProficiencyId
```
This example shows how to use the Remove-MgUserProfileSkill Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
