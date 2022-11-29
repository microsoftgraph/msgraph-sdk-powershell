### Example 1: Using the New-MgUserProfileSkill Cmdlet
```powershell
Import-Module Microsoft.Graph.People
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
New-MgUserProfileSkill -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileSkill Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
