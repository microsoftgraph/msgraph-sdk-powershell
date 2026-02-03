### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	categories = @(
	"Professional"
)
allowedAudiences = "organization"
displayName = "API Design"
proficiency = "generalProfessional"
collaborationTags = @(
"ableToMentor"
)
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileSkill -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileSkill Cmdlet.

