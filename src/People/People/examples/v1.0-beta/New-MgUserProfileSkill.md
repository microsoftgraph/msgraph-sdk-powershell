### Example 1: Using the New-MgBetaUserProfileSkill Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Categories = @(
		"Professional"
	)
	AllowedAudiences = "organization"
	DisplayName = "API Design"
	Proficiency = "generalProfessional"
	CollaborationTags = @(
		"ableToMentor"
	)
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileSkill -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileSkill Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
