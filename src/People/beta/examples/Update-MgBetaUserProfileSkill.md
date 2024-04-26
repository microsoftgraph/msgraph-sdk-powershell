### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	categories = @(
	"Professional"
)
proficiency = "advancedProfessional"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserProfileSkill -UserId $userId -SkillProficiencyId $skillProficiencyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileSkill Cmdlet.

