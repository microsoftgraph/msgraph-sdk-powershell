### Example 1: Using the Update-MgUserProfileSkill Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Categories = @(
		"Professional"
	)
	Proficiency = "advancedProfessional"
}
# A UPN can also be used as -UserId.
Update-MgUserProfileSkill -UserId $userId -SkillProficiencyId $skillProficiencyId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileSkill Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
