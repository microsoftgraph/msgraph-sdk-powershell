### Example 1: Using the Update-MgBetaUserProfileSkill Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Categories = @(
		"Professional"
	)
	Proficiency = "advancedProfessional"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfileSkill -UserId $userId -SkillProficiencyId $skillProficiencyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileSkill Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
